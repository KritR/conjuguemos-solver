using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using mshtml;
using spanishsolver;

//Wow just noticed I mispelled "amount" as "ammount" too lazy to fix it...
namespace spanishsolver
{
    public partial class spanishsolverForm : Form
    {
        
        // Basic Constructor
        public spanishsolverForm()
        {
            InitializeComponent();                                                  // Runs Standard Initializer
            createHandler();                                                        // Runs method to setup Handlers
        }

        // Variables
        bool rememberMeChecked, initialLaunch = false;
        bool loggedIn = false;                                                      // Keeps Track of wether User is Logged In
        bool wentBack = false;                                                      // Keeps Track of If the Browser Just went Back
        int pageChanged, maxPointsAllowed, loopEnd = 0;                             // Keeps Track of How Many Pages were Navigated

        // Creates a Handlers / Event Listeners
        private void createHandler()
        {
            // Calls saveNavigated() when Web Browser is Navigated
            webBrowser.Navigated += new WebBrowserNavigatedEventHandler(saveNavigated); 
        }

        // Handles the Page Changing and Button States
        private void saveNavigated(object sender, EventArgs e)
        {
            
            if (wentBack)                                                           // If the Back Button was Just Clicked >>
            {
                wentBack = false;                                                   // Resets Went Back Variable
            }
            else if (loggedIn) {                                                    // If the User Is Logged In & The ^ Condition >>
                pageChanged++;                                                      // Increments the pageChanged Integer 
            }
            updateBackButton();                                                     // Calls to Update State of Back Button
            updateForwardButton();                                                  // Calls to Update State of Forward Button
        }

        // Updates the state of the Back Button
        private void updateBackButton() 
        {
            if (pageChanged > 0)                                                    // If Pages Have been Navigated >>
            {
                buttonBack.Enabled = true;                                          // Enables Back Button
            }
            else                                                                    // If Pages Haven't been Navigated >>
            {
                buttonBack.Enabled = false;                                         // Disables Back Button
            }
        }

        // Updates the state of the Forward Button
        private void updateForwardButton() 
        {
            if (webBrowser.CanGoForward)                                            // If Web Browser can Go Forward >>
            {
                buttonForward.Enabled = true;                                       // Enables Forward Button
            }
            else                                                                    // If Web Browser Can't Go Forward >>
            {
                buttonForward.Enabled = false;                                      // Disables Forward Button
            }
        }

        // Unfinished Custom Activity Selection UI
        private void runCustomUI() 
        { 
            var head = webBrowser.Document.GetElementsByTagName("head")[0];         // Finds the Head Element of HTML File
            var scriptEl = webBrowser.Document.CreateElement("script");             // Creates a new Script
            IHTMLScriptElement element = (IHTMLScriptElement)scriptEl.DomElement;   // Gets the Script Element as An IHTMLScriptElement
            element.text = "function createUI() {}";                                // Sets the Content of the Script
            head.AppendChild(scriptEl);                                             // Adds Script Element to the Head of the HTML File
            webBrowser.Document.InvokeScript("createUI");                           // Runs the Script
        }

        private void runPointGetterTick(object sender, EventArgs e)
        {
            int pointsAmmountInt = -1;
            pointsAmmountInt = Convert.ToInt32(pointsAmmount.Text);
            loopEnd = loopEnd + 1;
            HtmlElement head = webBrowser.Document.GetElementsByTagName("head")[0];
            HtmlElement scriptEl = webBrowser.Document.CreateElement("script");
            IHTMLScriptElement element = (IHTMLScriptElement)scriptEl.DomElement;
            element.text = "function verifyAnswerHack() { verifyAnswer(); }";
            head.AppendChild(scriptEl);
            webBrowser.Document.InvokeScript("verifyAnswerHack");
            if (loopEnd == pointsAmmountInt)
            {
                ((Timer)sender).Stop();
                HtmlElement head3 = webBrowser.Document.GetElementsByTagName("head")[0];
                HtmlElement scriptEl3 = webBrowser.Document.CreateElement("script");
                IHTMLScriptElement element3 = (IHTMLScriptElement)scriptEl3.DomElement;
                element3.text = "function endHack() { stopClock(); document.sw.timer.value = '" + comboBoxTime.SelectedItem.ToString() + "'; }";
                head3.AppendChild(scriptEl3);
                webBrowser.Document.InvokeScript("endHack"); 
                loopEnd = 0;          
                pointsAmmount.Enabled = true;
                checkBoxShowAnswers.Enabled = true;
                ((Control)webBrowser).Enabled = true;
                buttonBack.Enabled = true;
                buttonForward.Enabled = true;
                buttonBeginFillBlank.Enabled = true;
                BeginScript.Enabled = true;
                comboBoxTime.Enabled = true;
                tabHack.Enabled = true;
                return;
            }
            
            HtmlElement head2 = webBrowser.Document.GetElementsByTagName("head")[0];
            HtmlElement scriptEl2 = webBrowser.Document.CreateElement("script");
            IHTMLScriptElement element2 = (IHTMLScriptElement)scriptEl2.DomElement;
            element2.text = "function progressHack() { if (solution.constructor === Array) { document.form.elements[entry].value = solution[0]; }else { document.form.elements[entry].value = solution; }}";
            head2.AppendChild(scriptEl2);
            webBrowser.Document.InvokeScript("progressHack");
        }

        // Implements the Point Gaining Script [ Look to Above Function for Explanation ]
        private void runPointGetter()
        {
            int[] selectionIncorrect = new int[Convert.ToInt32(pointsAmmount.Text)];
            int pointsAmmountInt = Convert.ToInt32(pointsAmmount.Text);
            Random randomInitializer = new Random();
            int randomInt = randomInitializer.Next(1, pointsAmmountInt);
            int x;
            if (checkBoxShowAnswers.Checked == false)
            {
                if (comboBoxIncorrect.SelectedIndex > Convert.ToInt32(pointsAmmount.Text))
                {
                    MessageBox.Show("Your amount of points marked incorrect is greater than the amount of points you would like to receve thus creating negative points!", "ERROR", 0);
                    return;
                }
                else if (comboBoxIncorrect.SelectedIndex == 0)
                {
                    HtmlElement head = webBrowser.Document.GetElementsByTagName("head")[0];
                    HtmlElement scriptEl = webBrowser.Document.CreateElement("script");
                    IHTMLScriptElement element = (IHTMLScriptElement)scriptEl.DomElement;
                    head.AppendChild(scriptEl);
                    element.text = "function beginHack() { var Repeater = 0; $('#startButton').click(); while (Repeater < " + pointsAmmount.Text + ") { Repeater++; if (solution.constructor === Array) { document.form.elements[entry].value = solution[0]; }else { document.form.elements[entry].value = solution; } verifyAnswer();} stopClock(); document.sw.timer.value = '" + comboBoxTime.SelectedItem.ToString() + "'; }";
                    webBrowser.Document.InvokeScript("beginHack");
                    return;
                }
                else
                {
                    HtmlElement head3 = webBrowser.Document.GetElementsByTagName("head")[0];
                    HtmlElement scriptEl3 = webBrowser.Document.CreateElement("script");
                    IHTMLScriptElement element3 = (IHTMLScriptElement)scriptEl3.DomElement;
                    for (x = 0; x < comboBoxIncorrect.SelectedIndex;)
                    { 
                        int rand = randomInitializer.Next(0, pointsAmmountInt - 1);
                        if (selectionIncorrect[rand] == 0)
                        {
                            selectionIncorrect[rand] = 1;
                            x++;
                        }
                    }
                    element3.text = "function beginHacka() { $('#startButton').click();}";
                    head3.AppendChild(scriptEl3);
                    webBrowser.Document.InvokeScript("beginHacka");
                    element3.text = "function endHacka() {stopClock(); document.sw.timer.value = '" + comboBoxTime.SelectedItem.ToString() + "'; }";
                    head3.AppendChild(scriptEl3);
                    element3.text = "function progressHacka() {if (solution.constructor === Array) {   document.form.elements[entry].value = solution[0];  if(solution[0].charAt(solution[0].length - 1) == 'a' || solution[0].charAt(solution[0].length - 1) == 'e' || solution[0].charAt(solution[0].length - 1) == 'i' || solution[0].charAt(solution[0].length - 1) == 'o' || solution[0].charAt(solution[0].length - 1) == 'u' ){   accent();  }else{   document.form.elements[entry].value += solution[0].charAt(solution[0].length - 1);  } }else{  document.form.elements[entry].value = solution;  if(solution.substr(solution.length-1) == 'a' || solution.substr(solution.length-1) == 'e' || solution.substr(solution.length-1) == 'i' || solution.substr(solution.length-1) == 'o' || solution.substr(solution.length-1) == 'u'){   spanishAccent();  }else{   document.form.elements[entry].value += solution.substr(solution.length-1) ;  }}verifyAnswer(); }";
                    head3.AppendChild(scriptEl3);
                    element3.text = "function progressHackb() { if (solution.constructor === Array) { document.form.elements[entry].value = solution[0]; }else { document.form.elements[entry].value = solution; }verifyAnswer(); }";
                    head3.AppendChild(scriptEl3);
                    foreach (var item in selectionIncorrect)
                    {
                        if (item == 1)
                        {
                            webBrowser.Document.InvokeScript("progressHacka");
                        }
                        else
                        {
                            webBrowser.Document.InvokeScript("progressHackb");
                        }
                    }
                    webBrowser.Document.InvokeScript("endHacka");
                }
                return;
            }
            //Makes everything disabled so the user cannot create any errors
            tabHack.Enabled = false;
            pointsAmmount.Enabled = false;
            checkBoxShowAnswers.Enabled = false;
            ((Control)webBrowser).Enabled = false;
            buttonBack.Enabled = false;
            buttonForward.Enabled = false;
            buttonBeginFillBlank.Enabled = false;
            BeginScript.Enabled = false;
            comboBoxTime.Enabled = false;
            HtmlElement head2 = webBrowser.Document.GetElementsByTagName("head")[0];
            HtmlElement scriptEl2 = webBrowser.Document.CreateElement("script");
            IHTMLScriptElement element2 = (IHTMLScriptElement)scriptEl2.DomElement;
            element2.text = "function beginHack() { $('#startButton').click(); if (solution.constructor === Array) { document.form.elements[entry].value = solution[0]; }else { document.form.elements[entry].value = solution; }}";
            head2.AppendChild(scriptEl2);
            webBrowser.Document.InvokeScript("beginHack");
            //Old java script where the user would not see what was entered in
            //element.text = "function beginHack() { var Repeater = 0; $('#startButton').click(); while (Repeater < " + pointsAmmount.Text + ") { Repeater++; if (solution.constructor === Array) { document.form.elements[entry].value = solution[0]; }else { document.form.elements[entry].value = solution; } verifyAnswer();} stopClock(); document.sw.timer.value = '0" + comboBoxTime.SelectedItem.ToString() + "'; }";
            var timer = new Timer();                                                // Creates a New Timer
            timer.Tick += new EventHandler(runPointGetterTick);                     // Every time timer ticks, runPointGetter will be called
            timer.Interval = 1000;                                                  // Timer will tick every 1 second
            timer.Enabled = true;                                                   // Enable the timer
            timer.Start();                                                          // Starts the Timer
        }
        
        // Runs when Begin Button is Clicked
        private void BeginScript_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pointsAmmount.Text))                      // If the User Input Doesn't Exists >>
            {                                                                       // Shows User An Appropriate Message
                MessageBox.Show("Please enter in a number between 1 and " + maxPointsAllowed.ToString() + " in the text box!!!","ERROR",0);                                                                                   
                return;
            }

            
            if (null != webBrowser.Document.GetElementById("clockInput"))           // If the Webpage Has a Timer / User on the Right Page >>
            {
                try
                {
                    runPointGetter();                                               // Runs Point Acquiring Script
                }
                catch (Exception)
                {
                    MessageBox.Show(comboBoxTime.SelectedItem.ToString());
                    return;
                }
            }
            else                                                                    // If the Webpage Doesn't Have a Timer >>
            {   
                                                                                    // It will Show an Error Message
                MessageBox.Show("Please Select a Valid Activity [with clock & one submit box]!","ERROR",0);
            }

        }


        // Makes sure Points is < or = maxPointsAllowed
        private void pointsAmmount_TextChanged(object sender, EventArgs e)
        {
            //This class runs everytime the textbox is altered with
            errorLabel.Visible = false;                                             // Sets the Error Label Visibility to False
            var pointsAmmountStr = pointsAmmount.Text;                              // Sets Variable to Input
            int pointsAmmountInt = -1;                                              // Sets the Int to a Random Number
            if (pointsAmmount.Text == "0")
            {
                pointsAmmount.Text = "";
                errorLabel.Visible = true;
                return;
            }
            try
            {
                pointsAmmountInt = Convert.ToInt32(pointsAmmountStr);               // Tries to Convert Input to a Number
            }
            catch (FormatException)                                                 // If it Fails >>
            {
                errorLabel.Visible = true;                                          // Shows an Error if the Input is not a Number
                pointsAmmount.Text = "";                                            // Resets the textbox
            }
            //Checks to see if it is greater than maxPointsAllowed 
            //(Don't want students to turn in 1000 point assignments in 5 minutes)
            if (pointsAmmountInt > maxPointsAllowed)                                // If the Input is > maxPointsAllowed >>
            {
                pointsAmmount.Text = maxPointsAllowed.ToString();                   // Sets the Input to maxPointsAllowed
                pointsAmmountInt = maxPointsAllowed;                                // And for some reason the local variable as well... 
            }
        }

        // Runs when the Login Button is Clicked
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ((Button)sender).Enabled=false;                                         // Disables the Button
            tryLogin();                                                             // Attempts the Login Process
        }

        // Attempts to Login
        private void tryLogin()
        {
            try
            {
                // Sets the textboxes of the html to the username and password
                webBrowser.Document.GetElementById("email").InnerText = userUserName.Text;
                webBrowser.Document.GetElementById("password").InnerText = userPassword.Text;
                webBrowser.Document.Forms[0].GetElementsByTagName("input")[2].InvokeMember("click");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                buttonLogin.Enabled = true;   
                return;
            }
            checkLogin();                                                           // If all goes well ... It checks if it logged in

        }

        // Sets up a Timer to see if Logged In once the Page Loads
        private void checkLogin() 
        {
            var timer = new Timer();                                                // Creates a New Timer
            timer.Tick += new EventHandler(waitLoad);                               // Every time timer ticks, timer_Tick will be called
            timer.Interval = 50;                                                    // Timer will tick every 1/20ths of a seconds
            timer.Enabled = true;                                                   // Enable the timer
            timer.Start();                                                          // Starts the Timer
        }

        // Waits for Page Load and then calls Login Handler
        private void waitLoad(Object sender, EventArgs e)
        {
            if (webBrowser.IsBusy == false)                                         // If the Browser is Not Loading >>
            {
                ((Timer)sender).Stop();                                             // Stops Timer [Constant Calling of this Event]
                handleLogin();                                                      // Handles the Login Success or Failure
            }
            
        }

        // Handles a Login Success or Fail
        private void handleLogin()
        {
            var selectionPage = "https://conjuguemos.com/student.php";              // Defines the Activity Selection Page
            if (webBrowser.Url.ToString().Equals(selectionPage))                    // If the User has Logged in >>
            {
                loggedIn = true;                                                    // Set the bool loggedIn to true
                setupSelectionScreen();                                             // Setup the Next Screen / UI
            }
            else                                                                    // If the Login Failed >>
            {
                MessageBox.Show("Try a valid username or password");                // Inform the User of the Failure
                buttonLogin.Enabled = true;                                         // Re-enables the Login Button

            }


        }

        // Sets up Web Browser UI
        private void setupSelectionScreen() 
        {
            if (rememberMe.Checked == true)
            {
                string FolderStr = Path.GetTempPath();
                File.Create(FolderStr + "/userpass.txt").Dispose();
                var objWriter = new System.IO.StreamWriter(FolderStr + "/userpass.txt");
                objWriter.WriteLine(userUserName.Text);
                objWriter.WriteLine(userPassword.Text);
                objWriter.Close();
            }
            else if (rememberMeChecked == false)
            {
                string FolderStr = Path.GetTempPath();
                var objWriter = new System.IO.StreamWriter(FolderStr + "/userpass.txt");
                objWriter.WriteLine("");
                objWriter.WriteLine("");
                objWriter.Close();
            }

            // Resizing Window
            this.MaximumSize = new Size(0, 0);                                 // Sets the Maximum Size of Window to [1280 by 726 (pixels)]
            this.MinimumSize = new Size(1280, 726);                                 // Sets the Minimum Size of Window to [1280 by 726 (pixels)]
            // Making Various Components Visible
            webBrowser.Visible = true;                                              // Makes the Web Browser Visible
            BeginScript.Visible = true;                                             // Makes the Begin Button Visible
            pointsAmmount.Visible = true;                                           // Makes the Points Input Visible
            labelAmmountPoints.Visible = true;                                      // Makes the Input Label Visible
            buttonForward.Visible = true;                                           // Makes the Forward Button Visible
            buttonBack.Visible = true;                                              // Makes the Back button Visible
            tabHack.Visible = true;
            buttonHelp.Visible = true;
            label4.Visible = true;
            comboBoxTime.Visible = true;
            label5.Visible = true;
            buttonHelp2.Visible = true;
            checkBoxShowAnswers.Visible = true;
            // Disposing Unnecessary Components
            label1.Dispose();                                                       // Disposes of Username Label
            label3.Dispose();                                                       // Disposes of Password Label
            buttonLogin.Dispose();                                                  // Disposes of Login Button
            userUserName.Dispose();                                                 // Disposes of Username Input
            userPassword.Dispose();                                                 // Disposes of Password Input
            rememberMe.Dispose();                                                   // Disposes of Remember Me ? Checkbox
            buttonHelp.Dispose();                                                   // Disposes of Help Button
            // Disabling Buttons
            buttonBack.Enabled = false;                                             // Disables Back Button
            // Other Web Browser Setup
            webBrowser.AllowWebBrowserDrop = false;                                 // Disables dropping of links onto browser
        }

        // Sets the Form Size when the Form Loads
        private void spanishsolverForm_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(250, 95);                                     
            this.MinimumSize = new Size(250, 95);                                     
            //this.MaximumSize = new Size(220, 170);                                  // Sets the Maximum Form Size to [220 by 170 (pixels)]
            //this.MinimumSize = new Size(220, 170);                                  // Sets the Minumum Form Size to [220 by 170 (pixels)]
            comboBoxTime.SelectedIndex = 4;
            comboBoxIncorrect.SelectedIndex = 0;
            //Check for user data in %TEMP%
            string TempFolderStr = Path.GetTempPath();
            if (File.Exists(TempFolderStr + "userpass.txt"))
            {
                try
                {
                    var objReader = new System.IO.StreamReader(TempFolderStr + "userpass.txt");
                    string Lineone = objReader.ReadLine();
                    string Linetwo = objReader.ReadLine();
                    if (Lineone == "" & Linetwo == "")
                    {
                        objReader.Dispose();
                        return;
                    }
                    userUserName.Text = Lineone;
                    userPassword.Text = Linetwo;
                    objReader.Dispose();
                    rememberMe.Checked = true;
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        // Shows About Box when the Help Button is Clicked
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            spanishsolver.AboutBox1 a = new spanishsolver.AboutBox1();              // Creates a new About Box
            a.Show();                                                               // Shows the About Box
        }

        // Called when the Back Button is Clicked
        private void buttonBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();                                                    // Makes the Web Browser go Back
        }

        //Called when Forward Button is Clicked
        private void buttonForward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();                                                 // Makes the Web Browser go Forward
        }

        private void buttonHelp2_Click(object sender, EventArgs e)
        {
            spanishsolver.AboutBox1 a = new spanishsolver.AboutBox1();              // Creates a new About Box
            a.Show();                                                               // Shows the About Box
        }

        private void buttonHelp3_Click(object sender, EventArgs e)
        {
            spanishsolver.AboutBox1 a = new spanishsolver.AboutBox1();              // Creates a new About Box
            a.Show();                                                               // Shows the About Box
        }

        private void buttonBeginFillBlank_Click(object sender, EventArgs e)
        {
            webBrowser.ScriptErrorsSuppressed = true;
            HtmlElement head = webBrowser.Document.GetElementsByTagName("head")[0];
            HtmlElement scriptEl = webBrowser.Document.CreateElement("script");
            IHTMLScriptElement element = (IHTMLScriptElement)scriptEl.DomElement;
            element.text = "function hackFillBlank() {var numAnswers = 0;var numtAnswers = 0;while (numAnswers < answers.length){numAnswers++;numtAnswers = numAnswers - 1;document.form.elements[numtAnswers].value = answers[numtAnswers];}}";
            head.AppendChild(scriptEl);
            webBrowser.Document.InvokeScript("hackFillBlank");
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            /*
            if (webBrowser.Url.ToString() == "http://conjuguemos.com/student.php/")
            {
                dynamic htmldoc = webBrowser.Document.DomDocument as dynamic;
                dynamic node = htmldoc.getElementById("stageContent") as dynamic;
                node.parentNode.removeChild(node);
            }
            */
            if (initialLaunch == false)
            {
                this.MaximumSize = new Size(220, 170);                                  // Sets the Maximum Form Size to [220 by 170 (pixels)]
                this.MinimumSize = new Size(220, 170);                                  // Sets the Minumum Form Size to [220 by 170 (pixels)]
                labelLoading.Visible = false;
                initialLaunch = true;
            }
            
        }


        private void rememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (rememberMe.Checked == false)
            {
                rememberMeChecked = false;
            }
            else
            {
                rememberMeChecked = true;
            }
        }

        private void comboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            maxPointsAllowed = (comboBoxTime.SelectedIndex + 1) * 8;
            labelAmmountPoints.Text = "Amount of points you would like (Max of " + maxPointsAllowed.ToString() + " Points)";
            /*int x = 0;
            int timeCheck = 0;
            do
            {
                timeCheck = timeCheck + 1;
                if (comboBoxTime.SelectedItem.ToString() == "0" + timeCheck.ToString() + ":00")
                {
                    maxPointsAllowed = timeCheck * 8;
                    labelAmmountPoints.Text = "Amount of points you would like (Max of " + maxPointsAllowed.ToString() + " Points)";
                    break;
                }
                if (timeCheck > 11)
                {
                    break;
                }
            } while (x == 0);*/
        }

        private void comboBoxIncorrect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIncorrect.SelectedIndex == 0)
                checkBoxShowAnswers.Enabled = true;
            else
                checkBoxShowAnswers.Enabled = false;
        }

        private void buttonViewHTML_Click(object sender, EventArgs e)
        {
            CurrentPageHTML.webBrowserHTML = webBrowser.DocumentText.ToString();
            CurrentPageHTML a = new CurrentPageHTML();
            a.Show();
        }

        private void buttonInjectScript_Click(object sender, EventArgs e)
        {
            webBrowser.ScriptErrorsSuppressed = false;
            FormInjectScript.spanishSolverF = this;
            HtmlElement head = webBrowser.Document.GetElementsByTagName("head")[0];
            FormInjectScript.webBrowserInjectHead = head;
            HtmlElement scriptEl = webBrowser.Document.CreateElement("script");
            FormInjectScript.webBrowserInjectScriptEL = scriptEl;
            IHTMLScriptElement element = (IHTMLScriptElement)scriptEl.DomElement;
            FormInjectScript.webBrowserInjectElement = element;
            FormInjectScript a = new FormInjectScript();
            a.Show();
        }
        public void invokeScript ()
        {
            webBrowser.Document.InvokeScript("injectElement");
        }
    }
}
