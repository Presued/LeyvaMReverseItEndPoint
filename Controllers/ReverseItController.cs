//Manuel l.
//10-26-22
//Reverse It
//What ever the user types in, it will reverse the users input 
//Peer Review: Christopher Prado 26OCT22 : I enjoyed using this program it accuretely reversed my #'s . I was also surprised to find that this program could reverse letters.





using Microsoft.AspNetCore.Mvc;

namespace LeyvaMReverseItEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseItController : ControllerBase
{
    [HttpGet]
    [Route("Mini7/{revIt}")]

    public string Reverse(string revIt)
    {
        char[] cArray = revIt.ToCharArray();
        string rReverse = String.Empty;
        for (int i = cArray.Length - 1; i > -1; i--)
        {
            rReverse += cArray[i];
        }
        return $" Okay So the original was {revIt} \n the reverse version of it is {rReverse}";
    }
}


