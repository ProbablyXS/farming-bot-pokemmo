Imports System.IO
Imports WindowsInput
Imports WindowsInput.Native
Imports System.Net.Mail

Module Paths

    Public ini As New clsIni(Environment.CurrentDirectory & "\OPTIONS.ini")

    Public largeur As Integer = Screen.PrimaryScreen.Bounds.Width
    Public hauteur As Integer = Screen.PrimaryScreen.Bounds.Height
    Public screenshot As New Bitmap(largeur, hauteur)

    Public simtest As New InputSimulator
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short

    Public watch01 As Stopwatch = Stopwatch.StartNew()
    Public watch02 As Stopwatch = Stopwatch.StartNew()

    Dim rdm As New Random()
    Dim val As String

    Dim result As Integer = 0

    Dim Factive As String = ""

    Dim val01 As String

    Public X As Double = Screen.PrimaryScreen.Bounds.Width()
    Public Y As Double = Screen.PrimaryScreen.Bounds.Height()

    Public Async Function calcul() As Task

        val01 = FCombatFarm.TextBox1.Text

        If (FCombatFarm.CheckBox2.Checked = True) Then 'DONATOR

            If (Factive = "CHEMIN_IP") Then

                val01 = val01 / 3217 'OK (Valeur la plus haute)

            ElseIf (Factive = "CHEMIN_FC") Then

                val01 = val01 / 3400

            ElseIf (Factive = "CHEMIN_5I") Then

                val01 = val01 / 3400

            ElseIf (Factive = "CHEMIN_7I") Then

                val01 = val01 / 3400

            ElseIf (Factive = "CHEMIN_2I") Then

                val01 = val01 / 3400

            ElseIf (Factive = "CHEMIN_BF") Then

                val01 = val01 / 3400

            ElseIf (Factive = "CHEMIN_R114") Then

                val01 = val01 / 3400

            End If



        Else

            If (Factive = "CHEMIN_IP") Then 'WITHOUT DONATOR

                val01 = val01 / 2600 'OK

            ElseIf (Factive = "CHEMIN_FC") Then

                val01 = val01 / 1100  'OK

            ElseIf (Factive = "CHEMIN_5I") Then

                val01 = val01 / 2100    'OK

            ElseIf (Factive = "CHEMIN_7I") Then

                val01 = val01 / 2750

            ElseIf (Factive = "CHEMIN_2I") Then

                val01 = val01 / 2750

            ElseIf (Factive = "CHEMIN_BF") Then

                val01 = val01 / 3400     'OK

            ElseIf (Factive = "CHEMIN_R114") Then

                val01 = val01 / 800     'OK

            End If

        End If

        Dim doubleval As Double = val01
        val01 = Math.Ceiling(doubleval)

        FCombatFarm.Label6.Text = val01

    End Function

    Public Async Function valresult() As Task

        If (FCombatFarm.CheckBox1.Checked = True) Then

            If (val01 = result) Then

                watch01.Stop()
                FCombatFarm.Button2.Enabled = True
                FCombatFarm.Button2.Text = "Resume"

                Do

                    Await Task.Delay(2000)

                Loop Until FCombatFarm.Button2.Text = "Resumed"

                For Each p As Process In Process.GetProcessesByName("javaw")

                    AppActivate(p.Id)

                Next

                result = 0

                watch01.Start()

            End If

        End If

    End Function

    Public Async Function COMBAT() As Task

        'COMBAT
        simtest.Keyboard.KeyPress(VirtualKeyCode.F8)

        Await Task.Delay(20000)  'durée à 20 secondes en cas de pluie

        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
        Await Task.Delay(300) 'NEW FIGHT with attk/anti evolve gestion
        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
        Await Task.Delay(15000) 'NEW FIGHT with attk/anti evolve gestion

        If (FCombatFarm.CheckBox3.Checked = True) Then

            Await Task.Delay(300) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_Z) 'NEW FIGHT with attk/anti evolve gestion  
            Await Task.Delay(300) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
            Await Task.Delay(2500) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_Z) 'NEW FIGHT with attk/anti evolve gestion  
            Await Task.Delay(300) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
            Await Task.Delay(2500) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_Z) 'NEW FIGHT with attk/anti evolve gestion
            Await Task.Delay(300) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
            Await Task.Delay(5000) 'NEW FIGHT with attk/anti evolve gestion


        End If

        result = result + 1
        FCombatFarm.Label14.Text = result
        Await valresult()



        simtest.Keyboard.KeyPress(VirtualKeyCode.F8)

        Await Task.Delay(20000)  'durée à 20 secondes en cas de pluie

        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
        Await Task.Delay(300) 'NEW FIGHT with attk/anti evolve gestion
        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
        Await Task.Delay(15000) 'NEW FIGHT with attk/anti evolve gestion

        If (FCombatFarm.CheckBox3.Checked = True) Then

            Await Task.Delay(300) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_Z) 'NEW FIGHT with attk/anti evolve gestion  
            Await Task.Delay(300) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
            Await Task.Delay(2500) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_Z) 'NEW FIGHT with attk/anti evolve gestion  
            Await Task.Delay(300) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
            Await Task.Delay(2500) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_Z) 'NEW FIGHT with attk/anti evolve gestion
            Await Task.Delay(300) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
            Await Task.Delay(5000) 'NEW FIGHT with attk/anti evolve gestion

        End If

        result = result + 1
        FCombatFarm.Label14.Text = result
        Await valresult()


        simtest.Keyboard.KeyPress(VirtualKeyCode.F8)

        Await Task.Delay(20000)  'durée à 20 secondes en cas de pluie

        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
        Await Task.Delay(300) 'NEW FIGHT with attk/anti evolve gestion
        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
        Await Task.Delay(15000) 'NEW FIGHT with attk/anti evolve gestion

        If (FCombatFarm.CheckBox3.Checked = True) Then

            Await Task.Delay(300) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_Z) 'NEW FIGHT with attk/anti evolve gestion  
            Await Task.Delay(300) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
            Await Task.Delay(2500) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_Z) 'NEW FIGHT with attk/anti evolve gestion  
            Await Task.Delay(300) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
            Await Task.Delay(2500) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_Z) 'NEW FIGHT with attk/anti evolve gestion
            Await Task.Delay(300) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
            Await Task.Delay(5000) 'NEW FIGHT with attk/anti evolve gestion

        End If

        result = result + 1
        FCombatFarm.Label14.Text = result
        Await valresult()

        simtest.Keyboard.KeyPress(VirtualKeyCode.F8)

        Await Task.Delay(20000)    'durée à 20 secondes en cas de pluie

        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
        Await Task.Delay(300) 'NEW FIGHT with attk/anti evolve gestion
        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
        Await Task.Delay(15000) 'NEW FIGHT with attk/anti evolve gestion

        If (FCombatFarm.CheckBox3.Checked = True) Then

            Await Task.Delay(300) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_Z) 'NEW FIGHT with attk/anti evolve gestion  
            Await Task.Delay(300) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
            Await Task.Delay(2500) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_Z) 'NEW FIGHT with attk/anti evolve gestion  
            Await Task.Delay(300) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
            Await Task.Delay(2500) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_Z) 'NEW FIGHT with attk/anti evolve gestion
            Await Task.Delay(300) 'NEW FIGHT with attk/anti evolve gestion
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'NEW FIGHT with attk/anti evolve gestion
            Await Task.Delay(5000) 'NEW FIGHT with attk/anti evolve gestion

        End If

        result = result + 1
        FCombatFarm.Label14.Text = result
        Await valresult()
        'COMBAT

    End Function

    Public Async Function Peche() As Task

        Dim val As Integer = 0

        Do

            Await Task.Delay(300)
            simtest.Keyboard.KeyPress(VirtualKeyCode.F4)
            Await Task.Delay(300)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(3000)

            val = val + 1

        Loop Until val = 6

    End Function

    Public Async Function Fight_safari() As Task

        simtest.Keyboard.KeyPress(VirtualKeyCode.DOWN) 'caillou
        Await Task.Delay(300) 'caillou
        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'caillou
        Await Task.Delay(4000) 'caillou

        'SCREENSHOT

        If (FSafariFarm.CheckBox1.Checked = True) Then

            If (IO.Directory.Exists("SCREENSHOTS")) Then



            Else

                IO.Directory.CreateDirectory("SCREENSHOTS")

            End If

            Dim graph As Graphics = Graphics.FromImage(screenshot)
            graph.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy)
            Dim namefile As String = "SCREENSHOTS/" & "screen_" & DateTime.Now.Hour & "_" & DateTime.Now.Minute & ".png"
            screenshot.Save(namefile)

            'SEND SCREENSHOTS FROM YOUR EMAIL
            If (FSafariFarm.CheckBox2.Checked = True) Then

                Try

                    Dim SmtpServer As New SmtpClient()
                    Dim mail As New MailMessage()

                    SmtpServer.Credentials = New _
                    Net.NetworkCredential("hrtmteam83@outlook.fr", "0JZeSZ!`xw1UwL")

                    SmtpServer.Port = 587
                    SmtpServer.Host = "SMTP.office365.com"
                    mail = New MailMessage()
                    mail.From = New MailAddress("hrtmteam83@outlook.fr")
                    mail.To.Add("hrtmteam83@outlook.fr")
                    mail.Subject = "BOT-POKEMMO"
                    mail.Body = "This is for testing SMTP mail"
                    SmtpServer.EnableSsl = True

                    Dim fileTXT As String = namefile
                    Dim data As Net.Mail.Attachment = New Net.Mail.Attachment(fileTXT)
                    data.Name = namefile
                    mail.Attachments.Add(data)

                    SmtpServer.Send(mail)
                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try


            End If
            'SEND SCREENSHOTS FROM YOUR EMAIL

        Else



        End If
        'SCREENSHOTS

        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'capture
        Await Task.Delay(13000) 'capture
        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'capture 2e try
        Await Task.Delay(12000) 'capture 2e try

        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_Z) 'Fermeture fiche post capture
        Await Task.Delay(300)


    End Function



    Public Async Sub CHEMIN_IP()

        Factive = "CHEMIN_IP"

        If (FCombatFarm.Button1.Text = "Start") Then

            FCombatFarm.Button1.Text = "Stop"

            watch01.Restart()
            FCombatFarm.Timer1.Start()


            Do

                watch02.Restart()

                If (FCombatFarm.CheckBox1.Checked = True) Then

                    Await calcul()

                End If

                For Each p As Process In Process.GetProcessesByName("javaw")

                    AppActivate(p.Id)

                    Await Task.Delay(1500)

                    'CODE HERE
                    Await CHEMIN_IP_CODE()
                    'CODE HERE

                    FCombatFarm.Label4.Text = FCombatFarm.Label4.Text + 1

                    Dim resul01 As String = ini.GetString("OPTIONS", "BestTime", "")

                    If (resul01 < FCombatFarm.Text) Then

                        FCombatFarm.Label13.Text = FCombatFarm.Label11.Text

                        ini.WriteString("OPTIONS", "BestTime", FCombatFarm.Label13.Text)

                    End If

                Next

            Loop Until FCombatFarm.Button1.Text = "OFF"

        Else

            FCombatFarm.Button1.Text = "OFF"
            Application.Restart()

        End If

        Exit Sub

    End Sub
    Public Async Function CHEMIN_IP_CODE() As Task

        'INSERT YOUR CODE HERE
        val = rdm.Next(1, 3)
        FCombatFarm.Label9.Text = val

        If (val = "1") Then

            'Centre pokemon league

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            Await Task.Delay(500)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            Await Task.Delay(1400)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)

            'Centre pokemon league


            Await Task.Delay(3000)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            Await Task.Delay(200)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)



            'DEHORS
            simtest.Keyboard.KeyPress(VirtualKeyCode.F2) 'VELO

            Await Task.Delay(500)


            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            Await Task.Delay(1500)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)



            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(300)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(900)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            Await Task.Delay(150)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(900)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(500)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1300)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)


            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(300)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            Await Task.Delay(500)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            'DEHORS




            Await Task.Delay(3500)

            'GROTTE
            Await COMBAT()

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            Await Task.Delay(600)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            'GROTTE

            'DEHORS
            Await Task.Delay(3000)

            simtest.Keyboard.KeyPress(VirtualKeyCode.F9)

            Await Task.Delay(1500)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            Await Task.Delay(380)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)

            Await Task.Delay(1200)

            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
            Await Task.Delay(500)
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)



            Await Task.Delay(6000)


            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(350)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)
            'DEHORS


            'Centre pokemon league
            Await Task.Delay(3000)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(300)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(430)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)
            Await Task.Delay(800)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(500)

            Await Task.Delay(450)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
            Await Task.Delay(450)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
            Await Task.Delay(450)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
            Await Task.Delay(450)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
            Await Task.Delay(450)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
            Await Task.Delay(450)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
            Await Task.Delay(450)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
            Await Task.Delay(3000)
            'Centre pokemon league

        ElseIf (val = "2") Then

            'CENTRE POKEMON LIGUE
            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            Await Task.Delay(500)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            Await Task.Delay(1400)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            'CENTRE POKEMON LIGUE

            Await Task.Delay(3000)

            'DEHORS


            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(2700)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)


            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1000)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)


            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(400)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)


            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(400)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)


            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1800)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)


            Await Task.Delay(1000)

            Dim val01 As String = rdm.Next(1, 3)

            If (val01 = "1") Then
                simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
                simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
                Await Task.Delay(400)
                simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
                simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            ElseIf (val01 = "2") Then
                simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
                Await Task.Delay(200)
                simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)

            End If


            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1800)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)


            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1600)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(1000)

            Dim val02 As String = rdm.Next(1, 4)

            If (val02 = "1") Then
                simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
                simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
                Await Task.Delay(3800)
                simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
                simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            ElseIf (val02 = "2") Then
                simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
                simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
                Await Task.Delay(2000)
                simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
                simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            ElseIf (val02 = "3") Then
                simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
                simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
                Await Task.Delay(1800)
                simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
                simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            End If


            Await Task.Delay(1000)

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(600)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)


            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1000)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)
            'DEHORS

            Await Task.Delay(3500)

            'GROTTE
            Await COMBAT()

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            Await Task.Delay(600)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            'GROTTE


            'DEHORS
            Await Task.Delay(3000)

            simtest.Keyboard.KeyPress(VirtualKeyCode.F9)

            Await Task.Delay(1500)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            Await Task.Delay(380)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)

            Await Task.Delay(1200)

            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
            Await Task.Delay(500)
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)



            Await Task.Delay(6000)


            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(350)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)
            'DEHORS


            'Centre pokemon league
            Await Task.Delay(3000)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(300)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(430)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)
            Await Task.Delay(800)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(500)

            Await Task.Delay(450)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
            Await Task.Delay(450)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
            Await Task.Delay(450)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
            Await Task.Delay(450)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
            Await Task.Delay(450)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
            Await Task.Delay(450)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
            Await Task.Delay(450)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
            Await Task.Delay(3000)
            'Centre pokemon league

        End If
        'STOP INSERING YOUR CODE

    End Function


    Public Async Sub CHEMIN_FC()

        Factive = "CHEMIN_FC"

        If (FCombatFarm.Button1.Text = "Start") Then

            FCombatFarm.Button1.Text = "Stop"

            watch01.Restart()
            FCombatFarm.Timer1.Start()


            Do

                watch02.Restart()

                If (FCombatFarm.CheckBox1.Checked = True) Then

                    Await calcul()

                End If

                For Each p As Process In Process.GetProcessesByName("javaw")

                    AppActivate(p.Id)

                    Await Task.Delay(1500)

                    'CODE HERE
                    Await CHEMIN_FC_CODE()
                    'CODE HERE

                    FCombatFarm.Label4.Text = FCombatFarm.Label4.Text + 1

                    Dim resul01 As String = File.ReadAllLines("Options.txt").ElementAt(0)

                    If (resul01 < FCombatFarm.Text) Then

                        FCombatFarm.Label13.Text = FCombatFarm.Label11.Text

                        Dim Foptions As String = "Options.txt"
                        Dim Lines() = File.ReadAllLines(Foptions)
                        Lines(0) = FCombatFarm.Label13.Text
                        File.WriteAllLines(Foptions, Lines)

                    End If

                Next

            Loop Until FCombatFarm.Button1.Text = "OFF"

        Else

            FCombatFarm.Button1.Text = "OFF"
            Application.Restart()

        End If

        Exit Sub

    End Sub
    Public Async Function CHEMIN_FC_CODE() As Task

        'INSERT YOUR CODE HERE

        'Centre pokemon 
        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)

        Await Task.Delay(2200)
        'Centre pokemon 

        'Dehors + (Random chemin)
        val = rdm.Next(1, 5)
        FCombatFarm.Label9.Text = val

        If (val = "1") Then

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(4000)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(2000)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(3200)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        ElseIf (val = "2") Then

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1000)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(2000)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(6000)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        ElseIf (val = "3") Then

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1150)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(2000)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(5850)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        ElseIf (val = "4") Then

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(3600)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(2000)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(2800)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        End If
        'Dehors

        Await Task.Delay(2000)

        'Batiment
        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)
        'Batiment

        Await Task.Delay(2000)

        'Dehors
        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(600)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(2000)
        'Dehors

        'Combat
        Await COMBAT()
        'Combat

        Await Task.Delay(3000)

        'Vol centre pokemon
        simtest.Keyboard.KeyPress(VirtualKeyCode.F9)

        Await Task.Delay(1500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
        Await Task.Delay(160)
        simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)

        Await Task.Delay(1200)

        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
        Await Task.Delay(500)
        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
        'Vol centre pokemon

        Await Task.Delay(4000)

        'Penetration dans le centre
        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(350)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)
        'Penetration dans le centre

        Await Task.Delay(3000)

        'Centre pokemon
        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(1200)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(3000)
        'Centre pokemon



        'STOP INSERING YOUR CODE


    End Function





    Public Async Sub CHEMIN_5I()

        Factive = "CHEMIN_5I"

        If (FCombatFarm.Button1.Text = "Start") Then

            FCombatFarm.Button1.Text = "Stop"

            watch01.Restart()
            FCombatFarm.Timer1.Start()


            Do

                watch02.Restart()

                If (FCombatFarm.CheckBox1.Checked = True) Then

                    Await calcul()

                End If

                For Each p As Process In Process.GetProcessesByName("javaw")

                    AppActivate(p.Id)

                    Await Task.Delay(1500)

                    'CODE HERE
                    Await CHEMIN_5I_CODE()
                    'CODE HERE

                    FCombatFarm.Label4.Text = FCombatFarm.Label4.Text + 1

                    Dim resul01 As String = File.ReadAllLines("Options.txt").ElementAt(0)

                    If (resul01 < FCombatFarm.Text) Then

                        FCombatFarm.Label13.Text = FCombatFarm.Label11.Text

                        Dim Foptions As String = "Options.txt"
                        Dim Lines() = File.ReadAllLines(Foptions)
                        Lines(0) = FCombatFarm.Label13.Text
                        File.WriteAllLines(Foptions, Lines)

                    End If

                Next

            Loop Until FCombatFarm.Button1.Text = "OFF"

        Else

            FCombatFarm.Button1.Text = "OFF"
            Application.Restart()

        End If

        Exit Sub

    End Sub
    Public Async Function CHEMIN_5I_CODE() As Task


        'INSERT YOUR CODE HERE

        'Centre pokemon 
        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)

        Await Task.Delay(2200)
        'Centre pokemon 

        'Dehors + (Random chemin)
        val = rdm.Next(1, 5)
        FCombatFarm.Label9.Text = val

        If (val = "1") Then

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1000)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(950)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(2600)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(950)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)


        ElseIf (val = "2") Then

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(150)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1000)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(800)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(2600)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(950)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        ElseIf (val = "3") Then

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1000)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(950)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(2450)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(950)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(150)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        ElseIf (val = "4") Then

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(150)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1000)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(800)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(2450)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(950)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(150)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        End If

        Await Task.Delay(2000)
        'Dehors

        'Combat

        Await COMBAT()

        'Combat

        Await Task.Delay(3000)

        'Vol centre pokemon
        simtest.Keyboard.KeyPress(VirtualKeyCode.F9)

        Await Task.Delay(1500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
        Await Task.Delay(80)
        simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)

        Await Task.Delay(300)

        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        Await Task.Delay(80)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)

        Await Task.Delay(1200)

        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
        Await Task.Delay(500)
        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
        'Vol centre pokemon

        Await Task.Delay(4000)

        'Penetration dans le centre
        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(350)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)
        'Penetration dans le centre

        Await Task.Delay(3000)

        'Centre pokemon
        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(1050)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(3000)
        'Centre pokemon



        'STOP INSERING YOUR CODE
    End Function





    Public Async Sub CHEMIN_7I()

        Factive = "CHEMIN_7I"

        If (FCombatFarm.Button1.Text = "Start") Then

            FCombatFarm.Button1.Text = "Stop"

            watch01.Restart()
            FCombatFarm.Timer1.Start()


            Do

                watch02.Restart()

                If (FCombatFarm.CheckBox1.Checked = True) Then

                    Await calcul()

                End If

                For Each p As Process In Process.GetProcessesByName("javaw")

                    AppActivate(p.Id)

                    Await Task.Delay(1500)

                    'CODE HERE
                    Await CHEMIN_7I_CODE()
                    'CODE HERE

                    FCombatFarm.Label4.Text = FCombatFarm.Label4.Text + 1

                    Dim resul01 As String = File.ReadAllLines("Options.txt").ElementAt(0)

                    If (resul01 < FCombatFarm.Text) Then

                        FCombatFarm.Label13.Text = FCombatFarm.Label11.Text

                        Dim Foptions As String = "Options.txt"
                        Dim Lines() = File.ReadAllLines(Foptions)
                        Lines(0) = FCombatFarm.Label13.Text
                        File.WriteAllLines(Foptions, Lines)

                    End If

                Next

            Loop Until FCombatFarm.Button1.Text = "OFF"

        Else

            FCombatFarm.Button1.Text = "OFF"
            Application.Restart()

        End If

        Exit Sub

    End Sub
    Public Async Function CHEMIN_7I_CODE() As Task

        'INSERT YOUR CODE HERE

        'Centre pokemon 
        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)

        Await Task.Delay(2200)
        'Centre pokemon 

        'Dehors 'Random chemin
        val = rdm.Next(1, 5)
        FCombatFarm.Label9.Text = val

        If (val = "1") Then

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(600)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(2600)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(900)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(450)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(600)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1050)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)


        ElseIf (val = "2") Then

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(900)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(2600)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(600)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(450)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(750)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1050)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        ElseIf (val = "3") Then

            simtest.Keyboard.KeyPress(VirtualKeyCode.F2) 'VELO

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(300)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1250)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(450)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(225)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(400)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(550)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        ElseIf (val = "4") Then

            simtest.Keyboard.KeyPress(VirtualKeyCode.F2) 'VELO

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(500)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1400)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(500)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(300)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(500)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(600)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        End If

        'Dehors

        Await Task.Delay(2000)

        'Combat
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_A)
        Await COMBAT()
        'Combat

        Await Task.Delay(3000)

        'Vol centre pokemon
        simtest.Keyboard.KeyPress(VirtualKeyCode.F9)

        Await Task.Delay(1500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        Await Task.Delay(40)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)

        Await Task.Delay(1200)

        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
        Await Task.Delay(500)
        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
        'Vol centre pokemon

        Await Task.Delay(4000)

        'Penetration dans le centre
        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(350)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)
        'Penetration dans le centre

        Await Task.Delay(3000)

        'Centre pokemon
        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(1050)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_A)
        Await Task.Delay(3000)
        'Centre pokemon



        'STOP INSERING YOUR CODE
    End Function




    Public Async Sub CHEMIN_2I()

        Factive = "CHEMIN_2I"

        If (FCombatFarm.Button1.Text = "Start") Then

            FCombatFarm.Button1.Text = "Stop"

            watch01.Restart()
            FCombatFarm.Timer1.Start()


            Do

                watch02.Restart()

                If (FCombatFarm.CheckBox1.Checked = True) Then

                    Await calcul()

                End If

                For Each p As Process In Process.GetProcessesByName("javaw")

                    AppActivate(p.Id)

                    Await Task.Delay(1500)

                    'CODE HERE
                    Await CHEMIN_2I_CODE()
                    'CODE HERE

                    FCombatFarm.Label4.Text = FCombatFarm.Label4.Text + 1

                    Dim resul01 As String = File.ReadAllLines("Options.txt").ElementAt(0)

                    If (resul01 < FCombatFarm.Text) Then

                        FCombatFarm.Label13.Text = FCombatFarm.Label11.Text

                        Dim Foptions As String = "Options.txt"
                        Dim Lines() = File.ReadAllLines(Foptions)
                        Lines(0) = FCombatFarm.Label13.Text
                        File.WriteAllLines(Foptions, Lines)

                    End If

                Next

            Loop Until FCombatFarm.Button1.Text = "OFF"

        Else

            FCombatFarm.Button1.Text = "OFF"
            Application.Restart()

        End If

        Exit Sub

    End Sub
    Public Async Function CHEMIN_2I_CODE() As Task

        'INSERT YOUR CODE HERE

        'Centre pokemon 
        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)

        Await Task.Delay(2200)
        'Centre pokemon 

        'Dehors 'Random chemin
        val = rdm.Next(1, 5)
        FCombatFarm.Label9.Text = val

        If (val = "1") Then

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1200)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(600)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1650)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1800)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)


        ElseIf (val = "2") Then

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1800)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(700)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1650)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1800)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)


        ElseIf (val = "3") Then

            simtest.Keyboard.KeyPress(VirtualKeyCode.F2) 'VELO

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(600)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(300)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)

            Await Task.Delay(810)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)


            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(900)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        ElseIf (val = "4") Then

            simtest.Keyboard.KeyPress(VirtualKeyCode.F2) 'VELO

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(500)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(250)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(600)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(600)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(650)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(900)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)


        End If

        Await Task.Delay(2000)
        'Dehors

        'Combat
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_A)
        Await Task.Delay(100)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_A)
        Await Task.Delay(2000)

        Await COMBAT()
        'Combat

        Await Task.Delay(3000)

        'Vol centre pokemon
        simtest.Keyboard.KeyPress(VirtualKeyCode.F9)

        Await Task.Delay(1500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        Await Task.Delay(40)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)

        Await Task.Delay(1200)

        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
        Await Task.Delay(500)
        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
        'Vol centre pokemon

        Await Task.Delay(4000)

        'Penetration dans le centre
        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(350)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)
        'Penetration dans le centre

        Await Task.Delay(3000)

        'Centre pokemon
        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(1050)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_A)
        Await Task.Delay(3000)
        'Centre pokemon



        'STOP INSERING YOUR CODE
    End Function




    Public Async Sub CHEMIN_BF()

        Factive = "CHEMIN_BF"

        If (FCombatFarm.Button1.Text = "Start") Then

            FCombatFarm.Button1.Text = "Stop"

            watch01.Restart()
            FCombatFarm.Timer1.Start()


            Do

                watch02.Restart()

                If (FCombatFarm.CheckBox1.Checked = True) Then

                    Await calcul()

                End If

                For Each p As Process In Process.GetProcessesByName("javaw")

                    AppActivate(p.Id)

                    Await Task.Delay(1500)

                    'CODE HERE
                    Await CHEMIN_BF_CODE()
                    'CODE HERE

                    FCombatFarm.Label4.Text = FCombatFarm.Label4.Text + 1

                    Dim resul01 As String = File.ReadAllLines("Options.txt").ElementAt(0)

                    If (resul01 < FCombatFarm.Text) Then

                        FCombatFarm.Label13.Text = FCombatFarm.Label11.Text

                        Dim Foptions As String = "Options.txt"
                        Dim Lines() = File.ReadAllLines(Foptions)
                        Lines(0) = FCombatFarm.Label13.Text
                        File.WriteAllLines(Foptions, Lines)

                    End If

                Next

            Loop Until FCombatFarm.Button1.Text = "OFF"

        Else

            FCombatFarm.Button1.Text = "OFF"
            Application.Restart()

        End If

        Exit Sub

    End Sub
    Public Async Function CHEMIN_BF_CODE() As Task

        'INSERT YOUR CODE HERE

        'Centre pokemon 
        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)

        Await Task.Delay(2200)
        'Centre pokemon 

        'Dehors 'Random chemin
        val = rdm.Next(1, 7)
        FCombatFarm.Label9.Text = val

        If (val = "1") Then

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(4050)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(900)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(900)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(300)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(900)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)


        ElseIf (val = "2") Then  'PERFECT A ADAPTER POUR RANDOMISATION

            simtest.Keyboard.KeyPress(VirtualKeyCode.F2) 'VELO

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1800)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(500)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1200)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(800)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)


        ElseIf (val = "3") Then

            simtest.Keyboard.KeyPress(VirtualKeyCode.F2) 'VELO

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(500)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1800)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(500)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1200)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(800)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        ElseIf (val = "4") Then

            simtest.Keyboard.KeyPress(VirtualKeyCode.F2) 'VELO

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1400)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(500)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1800)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(700)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        ElseIf (val = "5") Then

            simtest.Keyboard.KeyPress(VirtualKeyCode.F2) 'VELO

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1700)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(500)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1500)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(700)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        ElseIf (val = "6") Then

            simtest.Keyboard.KeyPress(VirtualKeyCode.F2) 'VELO

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1900)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(500)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1800)
            simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(700)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)


        End If

        Await Task.Delay(2000)
        'Dehors

        'Combat
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(2500)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_A)
        Await COMBAT()
        'Combat

        Await Task.Delay(3000)

        'Vol centre pokemon
        simtest.Keyboard.KeyPress(VirtualKeyCode.F9)

        Await Task.Delay(1200)

        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
        Await Task.Delay(500)
        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
        'Vol centre pokemon

        Await Task.Delay(4000)

        'Penetration dans le centre
        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(350)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        'Penetration dans le centre

        Await Task.Delay(3000)

        'Centre pokemon
        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(1050)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_A)
        Await Task.Delay(3000)
        'Centre pokemon



        'STOP INSERING YOUR CODE

    End Function

    Public Async Function FARM31() As Task

        If (FSafariFarm.Button4.Text = "Safari") Then

            FSafariFarm.Button4.Text = "Stop"

            watch01.Restart()
            FSafariFarm.Timer1.Start()


            Do

                watch02.Restart()

                For Each p As Process In Process.GetProcessesByName("javaw")

                    AppActivate(p.Id)

                    Await Task.Delay(1500)


                    'INSERT YOUR CODE HERE


                    Await Peche()

                    Await Task.Delay(15000)

                    Await Fight_safari()


                    'STOP INSERING YOUR CODE



                Next

            Loop Until FSafariFarm.Button4.Text = "OFF"

        Else

            FSafariFarm.Button4.Text = "OFF"
            Application.Restart()

        End If

    End Function

    Public Async Function AUTOFIGHT() As Task

        Do Until FTrainerFarm.temps > 100

            'INSERT YOUR CODE HERE

            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
            Await Task.Delay(500)
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
            Await Task.Delay(500)
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
            Await Task.Delay(1000)
            simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
            Await Task.Delay(1000)

            'STOP INSERING YOUR CODE

        Loop

        Await Task.Delay(1000)
        FTrainerFarm.temps = 0

    End Function

    Public Async Function F_VC() As Task

        If (FTrainerFarm.Button1.Text = "Vermilion City MEGA RUN") Then

            watch01.Start()
            FTrainerFarm.Timer2.Start()

            FTrainerFarm.Button1.Text = "Stop"

            For Each p As Process In Process.GetProcessesByName("javaw")

                AppActivate(p.Id)

                'INSERT YOUR CODE HERE

                'Vermilion City
                Await F_OVC()
                'Vermilion City


                Await Task.Delay(3000)

                'Vol centre pokemon Fuchsia city
                simtest.Keyboard.KeyPress(VirtualKeyCode.F9)

                Await Task.Delay(1500)

                simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
                Await Task.Delay(200)
                simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)

                Await Task.Delay(400)

                simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
                Await Task.Delay(250)
                simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)

                Await Task.Delay(1200)

                simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
                Await Task.Delay(500)
                simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
                'Vol centre pokemon Fuchsia city



                'Fuchsia City
                'Penetration dans le centre
                simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
                simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
                Await Task.Delay(350)
                simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
                simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)
                'Penetration dans le centre

                Await Task.Delay(3000)

                'Centre pokemon
                simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
                simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
                Await Task.Delay(1200)
                simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
                simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

                Await Task.Delay(500)

                Await Task.Delay(450)
                simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
                Await Task.Delay(450)
                simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
                Await Task.Delay(450)
                simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
                Await Task.Delay(450)
                simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
                Await Task.Delay(450)
                simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
                Await Task.Delay(450)
                simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
                Await Task.Delay(450)
                simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
                Await Task.Delay(3000)
                'Centre pokemon

                Await F_OFC()
                'Fuchsia City




                'Vol centre pokemon Lavender town
                simtest.Keyboard.KeyPress(VirtualKeyCode.F9)

                Await Task.Delay(1500)

                simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
                Await Task.Delay(100)
                simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)

                Await Task.Delay(400)

                simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
                Await Task.Delay(500)
                simtest.Keyboard.KeyUp(VirtualKeyCode.UP)

                Await Task.Delay(1200)

                simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
                Await Task.Delay(500)
                simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
                'Vol centre pokemon Lavender town

                Await Task.Delay(7000)

                'LAVENDER TOWN

                'Centre pokemon
                simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
                simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
                Await Task.Delay(1200)
                simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
                simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

                Await Task.Delay(3000)

                simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
                simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
                Await Task.Delay(1200)
                simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
                simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

                Await Task.Delay(450)
                simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
                Await Task.Delay(450)
                simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
                Await Task.Delay(450)
                simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
                Await Task.Delay(450)
                simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
                Await Task.Delay(450)
                simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
                Await Task.Delay(450)
                simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
                Await Task.Delay(450)
                simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
                'Centre pokemon

                Await Task.Delay(5000)

                Await F_OLT()
                'LAVENDER TOWN



                'STOP INSERING YOUR CODE

                watch01.Stop()
                FTrainerFarm.Timer2.Stop()

            Next

        Else

            Application.Restart()

        End If

    End Function


    Public Async Function VENTEFARM() As Task

        If (FSafariFarm.Button2.Text = "VENTE POKEMON PC TEST") Then

            FSafariFarm.Button2.Text = "Stop"

            watch01.Restart()
            FSafariFarm.Timer1.Start()


            Do

                watch02.Restart()

                For Each p As Process In Process.GetProcessesByName("javaw")

                    AppActivate(p.Id)

                    Await Task.Delay(1500)

                    'CODE HERE

                    'PREMIER TOUR POUR 5 POKEMON
                    'inside pc
                    simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
                    Await Task.Delay(1200)
                    simtest.Keyboard.KeyUp(VirtualKeyCode.VK_A)
                    Await Task.Delay(1000)


                    simtest.Keyboard.KeyPress(VirtualKeyCode.DOWN)
                    Await Task.Delay(500)


                    Dim rsts As Integer = 0

                    Do

                        rsts = rsts + 1

                        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'click case pokemon #1
                        Await Task.Delay(100)
                        simtest.Keyboard.KeyPress(VirtualKeyCode.DOWN)
                        Await Task.Delay(100)
                        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
                        Await Task.Delay(100)
                        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'click case pokemon #1



                        Await Task.Delay(100)
                        simtest.Keyboard.KeyPress(VirtualKeyCode.RIGHT) 'change case

                    Loop Until rsts = 5
                    'inside pc


                    'quite le pc
                    Await Task.Delay(500)
                    simtest.Keyboard.KeyPress(VirtualKeyCode.VK_Z)
                    'quite le pc

                    'vendre pc
                    Await Task.Delay(1000)
                    simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
                    Await Task.Delay(200)
                    simtest.Keyboard.KeyUp(VirtualKeyCode.VK_A)

                    Await Task.Delay(1000)
                    simtest.Keyboard.KeyPress(VirtualKeyCode.DOWN)
                    Await Task.Delay(1000)
                    simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)

                    Await Task.Delay(500)
                    simtest.Keyboard.KeyPress(VirtualKeyCode.RIGHT)
                    Await Task.Delay(500)
                    simtest.Keyboard.KeyPress(VirtualKeyCode.RIGHT)
                    Await Task.Delay(500)
                    simtest.Keyboard.KeyPress(VirtualKeyCode.RIGHT)

                    Dim lolilol As Integer = 0

                    Do

                        lolilol = lolilol + 1

                        simtest.Mouse.MoveMouseTo(Convert.ToDouble(766 * X), Convert.ToDouble(403 * Y))
                        Await Task.Delay(500)
                        simtest.Mouse.LeftButtonClick()

                        simtest.Mouse.MoveMouseTo(Convert.ToDouble(766 * X), Convert.ToDouble(345 * Y))
                        Await Task.Delay(500)
                        simtest.Mouse.LeftButtonClick()

                        Await Task.Delay(500)
                        simtest.Mouse.MoveMouseTo(Convert.ToDouble(832 * X), Convert.ToDouble(460 * Y))
                        Await Task.Delay(500)
                        simtest.Mouse.LeftButtonClick()

                        Await Task.Delay(500)
                        simtest.Keyboard.KeyPress(VirtualKeyCode.NUMPAD1)
                        simtest.Keyboard.KeyPress(VirtualKeyCode.NUMPAD5)
                        simtest.Keyboard.KeyPress(VirtualKeyCode.NUMPAD0)
                        simtest.Keyboard.KeyPress(VirtualKeyCode.NUMPAD0)


                        Await Task.Delay(500)
                        simtest.Mouse.MoveMouseTo(Convert.ToDouble(873 * X), Convert.ToDouble(545 * Y))
                        Await Task.Delay(500)
                        simtest.Mouse.LeftButtonClick()

                    Loop Until lolilol = 5

                    Await Task.Delay(1000)
                    simtest.Keyboard.KeyPress(VirtualKeyCode.VK_Z)
                    'vendre pc
                    'PREMIER TOUR POUR 5 POKEMON






                    'DEUXIEME TOUR POUR 5 POKEMON
                    'inside pc
                    simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
                    Await Task.Delay(1200)
                    simtest.Keyboard.KeyUp(VirtualKeyCode.VK_A)
                    Await Task.Delay(1000)


                    simtest.Keyboard.KeyPress(VirtualKeyCode.DOWN)
                    Await Task.Delay(500)

                    simtest.Keyboard.KeyPress(VirtualKeyCode.RIGHT)
                    Await Task.Delay(500)
                    simtest.Keyboard.KeyPress(VirtualKeyCode.RIGHT)
                    Await Task.Delay(500)
                    simtest.Keyboard.KeyPress(VirtualKeyCode.RIGHT)
                    Await Task.Delay(500)
                    simtest.Keyboard.KeyPress(VirtualKeyCode.RIGHT)
                    Await Task.Delay(500)
                    simtest.Keyboard.KeyPress(VirtualKeyCode.RIGHT)
                    Await Task.Delay(500)


                    Dim rsts2 As Integer = 0

                    Do

                        rsts2 = rsts2 + 1

                        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'click case pokemon #1
                        Await Task.Delay(100)
                        simtest.Keyboard.KeyPress(VirtualKeyCode.DOWN)
                        Await Task.Delay(100)
                        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
                        Await Task.Delay(100)
                        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A) 'click case pokemon #1



                        Await Task.Delay(100)
                        simtest.Keyboard.KeyPress(VirtualKeyCode.RIGHT) 'change case

                    Loop Until rsts2 = 5
                    'inside pc

                    'quite le pc
                    Await Task.Delay(500)
                    simtest.Keyboard.KeyPress(VirtualKeyCode.VK_Z)
                    'quite le pc

                    'vendre pc
                    Await Task.Delay(1000)
                    simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
                    Await Task.Delay(200)
                    simtest.Keyboard.KeyUp(VirtualKeyCode.VK_A)

                    Await Task.Delay(1000)
                    simtest.Keyboard.KeyPress(VirtualKeyCode.DOWN)
                    Await Task.Delay(1000)
                    simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)

                    Await Task.Delay(500)
                    simtest.Keyboard.KeyPress(VirtualKeyCode.RIGHT)
                    Await Task.Delay(500)
                    simtest.Keyboard.KeyPress(VirtualKeyCode.RIGHT)
                    Await Task.Delay(500)
                    simtest.Keyboard.KeyPress(VirtualKeyCode.RIGHT)

                    Dim lol2 As Integer = 0

                    Do

                        lol2 = lol2 + 1
                        simtest.Mouse.MoveMouseTo(Convert.ToDouble(766 * X), Convert.ToDouble(403 * Y))
                        Await Task.Delay(500)
                        simtest.Mouse.LeftButtonClick()

                        simtest.Mouse.MoveMouseTo(Convert.ToDouble(766 * X), Convert.ToDouble(345 * Y))
                        Await Task.Delay(500)
                        simtest.Mouse.LeftButtonClick()

                        Await Task.Delay(500)
                        simtest.Mouse.MoveMouseTo(Convert.ToDouble(832 * X), Convert.ToDouble(460 * Y))
                        Await Task.Delay(500)
                        simtest.Mouse.LeftButtonClick()

                        Await Task.Delay(500)
                        simtest.Keyboard.KeyPress(VirtualKeyCode.NUMPAD1)
                        simtest.Keyboard.KeyPress(VirtualKeyCode.NUMPAD5)
                        simtest.Keyboard.KeyPress(VirtualKeyCode.NUMPAD0)
                        simtest.Keyboard.KeyPress(VirtualKeyCode.NUMPAD0)


                        Await Task.Delay(500)
                        simtest.Mouse.MoveMouseTo(Convert.ToDouble(873 * X), Convert.ToDouble(545 * Y))
                        Await Task.Delay(500)
                        simtest.Mouse.LeftButtonClick()

                    Loop Until lol2 = 5

                    Await Task.Delay(1000)
                    simtest.Keyboard.KeyPress(VirtualKeyCode.VK_Z)
                    'vendre pc
                    'DEUXIEME TOUR POUR 5 POKEMON




                    Await Task.Delay(999999)
                    'vendre pc

                    'CODE HERE

                Next

            Loop Until FSafariFarm.Button1.Text = "OFF"

        Else

            FSafariFarm.Button1.Text = "OFF"
            Application.Restart()

        End If

    End Function


    Public Async Function TESTSOURISFARM() As Task

        simtest.Mouse.MoveMouseTo(Convert.ToDouble(766 * 65535 / X), Convert.ToDouble(403 * 65535 / Y))

        Await Task.Delay(500)
        simtest.Mouse.MoveMouseTo(Convert.ToDouble(766 * 65535 / X), Convert.ToDouble(345 * 65535 / Y))


        Await Task.Delay(500)
        simtest.Mouse.MoveMouseTo(Convert.ToDouble(832 * 65535 / X), Convert.ToDouble(460 * 65535 / Y))
        Await Task.Delay(500)

        simtest.Mouse.MoveMouseTo(Convert.ToDouble(873 * 65535 / X), Convert.ToDouble(545 * 65535 / Y))

        Await Task.Delay(5000)

        FTESTMOUSE.Close()

    End Function

    Public Async Function F_OVC() As Task

        'Vermilion City
        'Centre pokemon
        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
        'Centre pokemon

        Await Task.Delay(2200)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(2300)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(300)

        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(8000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(400)

        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(1000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(300)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(7000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(400)

        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(1600)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(400)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(400)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(400)

        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        Await Task.Delay(200)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)


        'Premier dresseur (vieux monsieur)
        FTrainerFarm.Timer1.Start()

        Await AUTOFIGHT() '1m40

        FTrainerFarm.Timer1.Stop()
        FTrainerFarm.temps = 0

        Await Task.Delay(1200)

        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z) 'Enlever commentaire
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z) 'Enlever commentaire
        'Premier dresseur (vieux monsieur)

        Await Task.Delay(1200)

        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        Await Task.Delay(400)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(4100)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(1000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        'Deuxieme dresseur (vieux monsieur)
        FTrainerFarm.Timer1.Start()

        Await AUTOFIGHT() '1m40

        FTrainerFarm.Timer1.Stop()
        FTrainerFarm.temps = 0

        Await Task.Delay(1200)

        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z) 'Enlever commentaire
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z) 'Enlever commentaire
        'Deuxieme dresseur (vieux monsieur)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(1500)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(1000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(2100)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(1000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        'Troisieme dresseur (vieux monsieur)
        FTrainerFarm.Timer1.Start()

        Await AUTOFIGHT() '1m40

        FTrainerFarm.Timer1.Stop()
        FTrainerFarm.temps = 0

        Await Task.Delay(1200)

        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z) 'Enlever commentaire
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z) 'Enlever commentaire
        'Troisieme dresseur (vieux monsieur)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(1900)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(1300)
        simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(600)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        'Quatrieme dresseur(vieux monsieur)
        FTrainerFarm.Timer1.Start()

        Await AUTOFIGHT() '1m40

        FTrainerFarm.Timer1.Stop()
        FTrainerFarm.temps = 0

        Await Task.Delay(1200)

        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z) 'Enlever commentaire
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z) 'Enlever commentaire
        'Quatrieme dresseur (vieux monsieur)


        'Vol centre pokemon
        simtest.Keyboard.KeyPress(VirtualKeyCode.F9)

        Await Task.Delay(1500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
        Await Task.Delay(245)
        simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)

        Await Task.Delay(1200)

        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
        Await Task.Delay(500)
        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
        'Vol centre pokemon

        Await Task.Delay(4000)
        'Vermilion City

    End Function

    Public Async Function F_OFC() As Task

        Await Task.Delay(2000)

        'Centre pokemon
        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
        'Centre pokemon

        Await Task.Delay(4000)

        'Dehors
        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(4000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(300)

        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(300)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(3200)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)
        'Dehors

        Await Task.Delay(2000)

        'Batiment
        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)
        'Batiment

        Await Task.Delay(2000)

        'Dehors
        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(500)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(1000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(14000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(400)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(350)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(600)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(2100)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(500)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        Await Task.Delay(150)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        Await Task.Delay(150)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)

        '1er dresseur (blonde)
        FTrainerFarm.Timer1.Start()

        Await AUTOFIGHT() '1m40

        FTrainerFarm.Timer1.Stop()
        FTrainerFarm.temps = 0

        Await Task.Delay(1200)

        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z) 'Enlever commentaire
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z) 'Enlever commentaire
        '1er dresseur (blonde)

        Await Task.Delay(1200)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        Await Task.Delay(1000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        Await Task.Delay(150)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)

        '2ème dresseur (blonde)
        FTrainerFarm.Timer1.Start()

        Await AUTOFIGHT() '1m40

        FTrainerFarm.Timer1.Stop()
        FTrainerFarm.temps = 0

        Await Task.Delay(1200)

        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z) 'Enlever commentaire
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z) 'Enlever commentaire
        '2ème dresseur (blonde)

        Await Task.Delay(1200)

        simtest.Keyboard.KeyDown(VirtualKeyCode.F2) 'VELO

        Await Task.Delay(1200)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        Await Task.Delay(1000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)

        Await Task.Delay(400)

        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        Await Task.Delay(1000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)

        Await Task.Delay(400)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        Await Task.Delay(2150)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        Await Task.Delay(5200)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
        Await Task.Delay(500)
        simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        Await Task.Delay(250)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        Await Task.Delay(3500)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        Await Task.Delay(400)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        Await Task.Delay(800)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        Await Task.Delay(400)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        Await Task.Delay(500)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
        Await Task.Delay(1100)
        simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        Await Task.Delay(500)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        Await Task.Delay(980)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        Await Task.Delay(400)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        Await Task.Delay(340)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        Await Task.Delay(400)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        Await Task.Delay(500)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        Await Task.Delay(300)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)

        '3ème dresseur (blonde)
        FTrainerFarm.Timer1.Start()

        Await AUTOFIGHT() '1m40

        FTrainerFarm.Timer1.Stop()
        FTrainerFarm.temps = 0

        Await Task.Delay(1200)

        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z) 'Enlever commentaire
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z) 'Enlever commentaire
        '3ème dresseur (blonde)

        Await Task.Delay(1200)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        Await Task.Delay(200)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)

        Await Task.Delay(1200)

        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        Await Task.Delay(150)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)

        '4ème dresseur (blonde)
        FTrainerFarm.Timer1.Start()

        Await AUTOFIGHT() '1m40

        FTrainerFarm.Timer1.Stop()
        FTrainerFarm.temps = 0

        Await Task.Delay(1200)

        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z) 'Enlever commentaire
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z) 'Enlever commentaire
        '4ème dresseur (blonde)

        Await Task.Delay(1200)
        'Dehors

    End Function

    Public Async Function F_OLT() As Task

        'Centre pokemon
        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
        'Centre pokemon

        Await Task.Delay(2000)

        'DEHORS
        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(600)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(2250)
        simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(1500)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(1980)
        simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(500)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        '1er dresseur (VIEUX)
        FTrainerFarm.Timer1.Start()

        Await AUTOFIGHT() '1m40

        FTrainerFarm.Timer1.Stop()
        FTrainerFarm.temps = 0

        Await Task.Delay(1200)

        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z) 'Enlever commentaire
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z) 'Enlever commentaire
        '1er dresseur (VIEUX)

        Await Task.Delay(1200)

        simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(1600)
        simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(1600)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(6000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(1300)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(1500)
        simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(2100)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(800)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        '2ème dresseur (VIEUX)
        FTrainerFarm.Timer1.Start()

        Await AUTOFIGHT() '1m40

        FTrainerFarm.Timer1.Stop()
        FTrainerFarm.temps = 0

        Await Task.Delay(1200)

        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z) 'Enlever commentaire
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z) 'Enlever commentaire
        '2ème dresseur (VIEUX)

    End Function

    Public Async Sub CHEMIN_R114()

        Factive = "CHEMIN_R114"

        If (FCombatFarm.Button1.Text = "Start") Then

            FCombatFarm.Button1.Text = "Stop"

            watch01.Restart()
            FCombatFarm.Timer1.Start()


            Do

                watch02.Restart()

                If (FCombatFarm.CheckBox1.Checked = True) Then

                    Await calcul()

                End If

                For Each p As Process In Process.GetProcessesByName("javaw")

                    AppActivate(p.Id)

                    Await Task.Delay(1500)

                    'CODE HERE
                    Await CHEMIN_R114_CODE()
                    'CODE HERE

                    FCombatFarm.Label4.Text = FCombatFarm.Label4.Text + 1

                    Dim resul01 As String = File.ReadAllLines("Options.txt").ElementAt(0)

                    If (resul01 < FCombatFarm.Text) Then

                        FCombatFarm.Label13.Text = FCombatFarm.Label11.Text

                        Dim Foptions As String = "Options.txt"
                        Dim Lines() = File.ReadAllLines(Foptions)
                        Lines(0) = FCombatFarm.Label13.Text
                        File.WriteAllLines(Foptions, Lines)

                    End If

                Next

            Loop Until FCombatFarm.Button1.Text = "OFF"

        Else

            FCombatFarm.Button1.Text = "OFF"
            Application.Restart()

        End If

        Exit Sub

    End Sub
    Public Async Function CHEMIN_R114_CODE() As Task

        'INSERT YOUR CODE HERE

        'Centre pokemon 
        simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)

        Await Task.Delay(2200)
        'Centre pokemon 

        'Dehors 'Random chemin
        val = rdm.Next(1, 4)
        FCombatFarm.Label9.Text = val

        If (val = "1") Then

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(300)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(5300)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)


            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(200)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)


        ElseIf (val = "2") Then

            simtest.Keyboard.KeyPress(VirtualKeyCode.F2) 'VELO

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            Await Task.Delay(900)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            Await Task.Delay(1000)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            Await Task.Delay(1000)
            simtest.Keyboard.KeyUp(VirtualKeyCode.UP)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            Await Task.Delay(500)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            Await Task.Delay(1000)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            Await Task.Delay(3200)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)


        ElseIf (val = "3") Then


            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(300)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)

            simtest.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(5300)
            simtest.Keyboard.KeyUp(VirtualKeyCode.LEFT)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            Await Task.Delay(300)


            simtest.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            Await Task.Delay(1000)
            simtest.Keyboard.KeyUp(VirtualKeyCode.DOWN)
            simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            'ElseIf (val = "4") Then

            '    simtest.Keyboard.KeyPress(VirtualKeyCode.F2) 'VELO

            '    Await Task.Delay(300)

            '    simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            '    simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            '    Await Task.Delay(500)
            '    simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            '    simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            '    Await Task.Delay(300)

            '    simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            '    simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            '    Await Task.Delay(250)
            '    simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            '    simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            '    Await Task.Delay(300)

            '    simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            '    simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            '    Await Task.Delay(600)
            '    simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            '    simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            '    Await Task.Delay(300)

            '    simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            '    simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            '    Await Task.Delay(600)
            '    simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            '    simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            '    Await Task.Delay(300)

            '    simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            '    simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            '    Await Task.Delay(650)
            '    simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)
            '    simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

            '    Await Task.Delay(300)

            '    simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
            '    simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
            '    Await Task.Delay(900)
            '    simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
            '    simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)


        End If

        Await Task.Delay(2000)
        'Dehors

        'Combat
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_A)
        Await Task.Delay(100)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(2000)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_A)
        Await Task.Delay(2000)

        Await COMBAT()
        'Combat

        Await Task.Delay(3000)

        'Vol centre pokemon
        simtest.Keyboard.KeyPress(VirtualKeyCode.F9)

        Await Task.Delay(1500)

        simtest.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
        Await Task.Delay(20)
        simtest.Keyboard.KeyUp(VirtualKeyCode.RIGHT)

        Await Task.Delay(1200)

        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
        Await Task.Delay(500)
        simtest.Keyboard.KeyPress(VirtualKeyCode.VK_A)
        'Vol centre pokemon

        Await Task.Delay(4000)

        'Penetration dans le centre
        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(350)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)
        'Penetration dans le centre

        Await Task.Delay(3000)

        'Centre pokemon
        simtest.Keyboard.KeyDown(VirtualKeyCode.UP)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_Z)
        Await Task.Delay(1050)
        simtest.Keyboard.KeyUp(VirtualKeyCode.UP)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_Z)

        Await Task.Delay(500)

        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyDown(VirtualKeyCode.VK_A)
        Await Task.Delay(450)
        simtest.Keyboard.KeyUp(VirtualKeyCode.VK_A)
        Await Task.Delay(3000)
        'Centre pokemon



        'STOP INSERING YOUR CODE
    End Function

End Module
