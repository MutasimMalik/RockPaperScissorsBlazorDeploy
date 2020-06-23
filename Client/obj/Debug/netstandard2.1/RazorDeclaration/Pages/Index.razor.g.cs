#pragma checksum "E:\Blazor\RockPaperScissorBlazorV2\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee2e26ef8d84f484820640d4428b3d2ae8b3f7d3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RockPaperScissorBlazorV2.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Blazor\RockPaperScissorBlazorV2\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Blazor\RockPaperScissorBlazorV2\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Blazor\RockPaperScissorBlazorV2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Blazor\RockPaperScissorBlazorV2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Blazor\RockPaperScissorBlazorV2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Blazor\RockPaperScissorBlazorV2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Blazor\RockPaperScissorBlazorV2\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Blazor\RockPaperScissorBlazorV2\Client\_Imports.razor"
using RockPaperScissorBlazorV2.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Blazor\RockPaperScissorBlazorV2\Client\_Imports.razor"
using RockPaperScissorBlazorV2.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Blazor\RockPaperScissorBlazorV2\Client\Pages\Index.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Blazor\RockPaperScissorBlazorV2\Client\Pages\Index.razor"
using RockPaperScissorBlazorV2.Client.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "E:\Blazor\RockPaperScissorBlazorV2\Client\Pages\Index.razor"
      
    List<Hand> hands = new List<Hand>()
    {
        new Hand{Selection = OptionRPS.Paper, LosesAgainst = OptionRPS.Scissors,
            WinsAgainst = OptionRPS.Rock, Image = "paper.png"},

        new Hand{Selection = OptionRPS.Rock, LosesAgainst = OptionRPS.Paper,
            WinsAgainst = OptionRPS.Scissors, Image = "rock.png"},

        new Hand{Selection = OptionRPS.Scissors, LosesAgainst=OptionRPS.Rock,
            WinsAgainst = OptionRPS.Paper, Image = "Scissors.png"}
    };

        Timer timer;
        Hand opponentHand;
        string resultMessage = string.Empty;
        string resultMessageColor = string.Empty;

    protected override void OnInitialized()
    {
        opponentHand = hands[0];
        timer = new Timer();
        timer.Interval = 100;
        timer.Elapsed += TimerOnElapsed;
        timer.Start();
    }

    int indexOpponentHand = 0;

    private void TimerOnElapsed(object sender, ElapsedEventArgs e)
    {
        indexOpponentHand = (indexOpponentHand + 1) % hands.Count;
        opponentHand = hands[indexOpponentHand];
        StateHasChanged();
    }

    private void SelectHand(Hand hand)
    {
        timer.Stop();
        var result = hand.PlayAgainst(opponentHand);

        if (result == GameStatus.Victory)
        {
            resultMessage = "You Win!!!";
            resultMessageColor = "green";
        }
        else if (result == GameStatus.Loss)
        {
            resultMessage = "You Lose!!!";
            resultMessageColor = "red";
        }
        else
        {
            resultMessage = "That is a Draw!!!";
            resultMessageColor = "black";
        }
    }

    private void PlayAgain()
    {
        timer.Start();
        resultMessage = string.Empty;
    }

    public void Dispose()
    {
        if (timer != null)
        {
            timer.Dispose();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
