This sample application is developed using Xamarin Forms, It explains how to show a login form in the screen, This application describes how to use a device specific implementation to a button click, Let's see how we can do that

Show Login form in the main page as below, and also device specific styling 

```html
<ContentPage.Padding>
        <OnPlatform x:TypeArguments="Thickness">
            <OnPlatform.Android>10,20,10,20</OnPlatform.Android>
        </OnPlatform>
    </ContentPage.Padding>

    <StackLayout>
        <Label Text="Login" HorizontalTextAlignment="Center" VerticalTextAlignment="Center"></Label>
        <Label Text="User Name"></Label>
        <Entry x:Name="userName"></Entry>
        <Label Text="Password"></Label>
        <Entry x:Name="password" IsPassword="True"></Entry>
        <Button Text="Login!" Clicked="OnButtonClick"></Button>
        <Label x:Name="message"/>
    </StackLayout>
```
In the code behind, you can call OS specific implementation like this, 
Create a interface and override interface in OS specific class, from the shared project it gets called relevant implementation 

    var userlogin = DependencyService.Get<IUserLogin>();
    bool success = await userlogin.Login(userName.Text, password.Text);
    
    [assembly: Dependency(typeof(UserLogin))]
    namespace loginview.Droid
    {
        public class UserLogin : IUserLogin
       {
            public Task<bool> Login(string username, string password)
           {
                if (username == password)
                    return Task.FromResult<bool>(true);
                return Task.FromResult<bool>(false);
            }
        }
     }
