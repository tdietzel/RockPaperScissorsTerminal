namespace RockPaperScissors.UserInterfaceModels
{
  class WelcomeBanner
  {
    public static string Welcome { get; } = @"
╦═╗┌─┐┌─┐┬┌─  ╔═╗┌─┐┌─┐┌─┐┬─┐  ╔═╗┌─┐┬┌─┐┌─┐┌─┐┬─┐┌─┐
╠╦╝│ ││  ├┴┐  ╠═╝├─┤├─┘├┤ ├┬┘  ╚═╗│  │└─┐└─┐│ │├┬┘└─┐
╩╚═└─┘└─┘┴ ┴  ╩  ┴ ┴┴  └─┘┴└─  ╚═╝└─┘┴└─┘└─┘└─┘┴└─└─┘                                                                                                                       
    ";
  }

  class Player1WinBanner
  {
    public static string Player1Win { get; } = @"
╔═╗╦  ╔═╗╦ ╦╔═╗╦═╗  ╔═╗╔╗╔╔═╗  ╦ ╦╦╔╗╔╔═╗
╠═╝║  ╠═╣╚╦╝║╣ ╠╦╝  ║ ║║║║║╣   ║║║║║║║╚═╗
╩  ╩═╝╩ ╩ ╩ ╚═╝╩╚═  ╚═╝╝╚╝╚═╝  ╚╩╝╩╝╚╝╚═╝
    ";
  }
  
  class Player2WinBanner
  {
    public static string Player2Win { get; } = @"
╔═╗╦  ╔═╗╦ ╦╔═╗╦═╗  ╔╦╗╦ ╦╔═╗  ╦ ╦╦╔╗╔╔═╗
╠═╝║  ╠═╣╚╦╝║╣ ╠╦╝   ║ ║║║║ ║  ║║║║║║║╚═╗
╩  ╩═╝╩ ╩ ╩ ╚═╝╩╚═   ╩ ╚╩╝╚═╝  ╚╩╝╩╝╚╝╚═╝
    ";
  }
  class Player3WinBanner
  {
    public static string Player3Win { get; } = @"
╔═╗╦  ╔═╗╦ ╦╔═╗╦═╗  ╔╦╗╦ ╦╦═╗╔═╗╔═╗  ╦ ╦╦╔╗╔╔═╗
╠═╝║  ╠═╣╚╦╝║╣ ╠╦╝   ║ ╠═╣╠╦╝║╣ ║╣   ║║║║║║║╚═╗
╩  ╩═╝╩ ╩ ╩ ╚═╝╩╚═   ╩ ╩ ╩╩╚═╚═╝╚═╝  ╚╩╝╩╝╚╝╚═╝
    ";
  }

class DrawBanner
  {
    public static string Draw { get; } = @"
╔╦╗╦═╗╔═╗╦ ╦
 ║║╠╦╝╠═╣║║║
═╩╝╩╚═╩ ╩╚╩╝
 ";
  }
  class GoodbyeBanner
  {
    public static string Goodbye { get; } = @"
    
    ";
  }
}