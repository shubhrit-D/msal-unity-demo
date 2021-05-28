using UnityEngine;
using UnityEngine.UI;
using Microsoft.Identity.Client;

public class GetAuthentication : MonoBehaviour
{
    [SerializeField]
    private string ClientID;    // client ID
    [SerializeField]
    private InputField username;    // username
    [SerializeField]
    private InputField password;    // password

    private string userName;
    private string pswd;
    private static string TenantID = "";    // Your Tenant ID
    private static string Authority = "https://login.microsoftonline.com/" + TenantID;

    string[] scopes = { "User.Read" };
    public Text myText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void clicked()
    {
        userName = username.text;
        pswd = password.text;
        getAuth();
    }

    /// <summary>
    /// The method authenticates to the provided client id and username and password.
    /// </summary>
    public async void getAuth()
    {
        var password = new System.Security.SecureString();
        IPublicClientApplication app = PublicClientApplicationBuilder
            .Create(ClientID)
            .WithAuthority(Authority)
            .Build();

        for (int i = 0; i < pswd.Length; i++)
        {
            password.AppendChar(pswd[i]);
        }

        try
        {
            AuthenticationResult authResult = await app.AcquireTokenByUsernamePassword(scopes, userName, password)
            .ExecuteAsync();
            myText.text = authResult.AccessToken;
        }

        catch (MsalClientException ex)
        {
            myText.text = ex.ToString();
        }
    }
}
