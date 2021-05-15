# Safe-Pass
SafePass is a simple and minimalistic windows form application, which enables to store all our passwords securely, in one spot. It was originally an experimental project for the 
demonstration of Windows Forms in C#, and MySql.There are three modules in the app, namely:
<ul>
<li>Profile</li>
<li>Vault</li>
<li>Password Generator</li>
</ul>
<h3>Vault</h3>
The vault is the main component of the safepass application. where we store all the passwords of the currently logged in user. Inorder to store the password, we have 
to provide the nickname, username/email of the account to which we want to store the password, and the actual password. The password are stored after AES-256 encryption, 
for security.
<h3>Profile</h3>
In this section, we can edit the user info like the email, password etc.<b>Note:The master password isn't actually encrypted, its SHA256 value is stored in the DB, and 'll be used at
time of login. This section gives info about the last edit, logout, and user info.</b>
<h3>PassGen</h3>
We can create strong passwords, by just sliding the slider to our needs, and can copy the value to the clip board for future use. The strength is shown at the time of sliding.

<h3>Requirements:</h3> 
<ul>
<li>Visual Studio 2019</li>
<li>MySQL</li>
<li>.NET Framework</li>
</ul>

To run the project you need to create the DB, and the required SQL file is provided in the sql folder.
<b>Note : This is just an experimental project and is in no means, a replacement to current password managers.</b>
