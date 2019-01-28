using System;
using System.Configuration;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Azure;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

// For more information about this template visit http://aka.ms/azurebots-csharp-luis
[Serializable]
public class BasicLuisDialog : LuisDialog<object>
{
    public BasicLuisDialog() : base(new LuisService(new LuisModelAttribute(
        ConfigurationManager.AppSettings["LuisAppId"], 
        ConfigurationManager.AppSettings["LuisAPIKey"], 
        domain: ConfigurationManager.AppSettings["LuisAPIHostName"])))
    {
    }

    [LuisIntent("None")]
    public async Task NoneIntent(IDialogContext context, LuisResult result)
    {
        await this.ShowLuisResult(context, result);
    }

    [LuisIntent("choose")]
    public async Task ChooseIntent(IDialogContext context, LuisResult result)
    {
        await this.ShowLuisResult(context, result);
        await context.PostAsync($"And you should really go for a bike, it's always the best way to go");
    }

    private async Task ShowLuisResult(IDialogContext context, LuisResult result) 
    {
        await context.PostAsync($"You have reached {result.Intents[0].Intent} with {result.Intents[0].Score}. You said: {result.Query}");
        context.Wait(MessageReceived);
    }
}

