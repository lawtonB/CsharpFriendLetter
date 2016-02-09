using Nancy;
using Letter.Objects;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        LetterVariables myLetterVariables = new LetterVariables
        {
          Recipient = "Bob",
          Sender = "John"
        };
        return View["hello.html", myLetterVariables];
      };

      Get["/form"] = _ =>
      {
        return View["form.html"];
      };

      Get["/greeting_card"] = _ =>
      {
        LetterVariables myLetterVariables = new LetterVariables
      {
        Sender = Request.Query["sender"],
        Recipient = Request.Query["recipient"]
      };
      return View["hello.html",  myLetterVariables];
      };
    }
  }
}
