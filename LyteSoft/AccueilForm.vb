﻿Imports MySql.Data.MySqlClient
Imports System.Data.Odbc
Imports System.IO

Public Class AccueilForm

    'Dim connect As New DataBaseManipulation()

    'Asynchronous load of forms

    Private Sub GunaButtonSeConnecter_Click(sender As Object, e As EventArgs) Handles GunaButtonActivation.Click

        Dim licence As New Licence()
        licence.gestionDesLicence()

        ActivationForm.Show()
        ActivationForm.TopMost = True

    End Sub

    Private Sub GunaButtonAnnulerAccueil_Click(sender As Object, e As EventArgs) Handles GunaButtonAnnulerAccueil.Click

        GunaLabelNomUtilisateur.Text = ""
        GunaLabelNomUtilisateur.Visible = False
        GunaLineTextBoxUsername.Clear()
        GunaLineTextBoxMotDePasse.Clear()
        GunaCheckBoxVersion.Checked = False
        GunaLabelVersion.Visible = False
        GunaComboBoxVersion.Visible = False
        'GunaTransitionAnimation.Show(PanelAccueil)
        GunaTransitionAnimation.Hide(PanelConnexion)

    End Sub

    Private Sub GunaButtonOuvrirSession_Click(sender As Object, e As EventArgs) Handles GunaButtonOuvrirSession.Click
        'login

        Dim premiereConnexion As Boolean = True

        Dim loginQuery As String = ""

        If GlobalVariable.databaseType = "MYSQL" Then
            loginQuery = "SELECT * FROM utilisateurs WHERE CODE_UTILISATEUR = @CODE_UTILISATEUR AND PASSWORD_UTILISATEUR = @PASSWORD_UTILISATEUR"
        ElseIf GlobalVariable.databaseType = "ODBC" Or GlobalVariable.databaseType = "ACCESS" Then
            loginQuery = "SELECT * FROM utilisateurs WHERE CODE_UTILISATEUR = ? AND PASSWORD_UTILISATEUR = ?"
        End If

        Dim table As New DataTable()

        Dim languageMessage As String = ""
        Dim languageTitle As String = ""
        Dim actionLanguage As String = ""

        If (verifyFields("login")) Then

            If GlobalVariable.databaseType = "MYSQL" Then

                Dim command As MySqlCommand

                command = New MySqlCommand(loginQuery, GlobalVariable.connect)
                command.Parameters.Add("@CODE_UTILISATEUR", MySqlDbType.VarChar).Value = GunaLineTextBoxUsername.Text
                command.Parameters.Add("@PASSWORD_UTILISATEUR", MySqlDbType.VarChar).Value = GunaLineTextBoxMotDePasse.Text

                table.Load(command.ExecuteReader())

            ElseIf GlobalVariable.databaseType = "ODBC" Or GlobalVariable.databaseType = "ACCESS" Then

                'Dim selCommand As New OdbcCommand(loginQuery, GlobalVariable.sqlConnection)
                'selCommand.Parameters.Add("@CODE_UTILISATEUR", OdbcType.VarChar).Value = GunaLineTextBoxUsername.Text
                'selCommand.Parameters.Add("@PASSWORD_UTILISATEUR", OdbcType.VarChar).Value = GunaLineTextBoxMotDePasse.Text

                'Dim reader As OdbcDataReader = selCommand.ExecuteReader()

                'table.Load(reader)

            End If

            Dim client As String = ""

            If table.Rows.Count > 0 Then
                client = table.Rows(0)("NOM_UTILISATEUR")
            End If

            If Trim(client.ToUpper()).Equals("CLIENT") Then

                If table.Rows.Count > 0 Then

                    GlobalVariable.DateDeTravail = Convert.ToDateTime(Functions.ObtenirDateDeTravail())

                    GlobalVariable.societe = Functions.allTableFields("societe")

                    GlobalVariable.codeAgence = table.Rows(0)("NUM_AGENCE")

                    GlobalVariable.AgenceActuelle = Functions.getElementByCode(GlobalVariable.codeAgence, "agence", "CODE_AGENCE")

                    GlobalVariable.ConnectedUser = table

                End If

                CustomCommandForm.Show()
                Me.Close()

            Else

                If table.Rows.Count > 0 Then
                    Dim page As Integer = 1
                    Dim mainwindow As New MainWindow()
                    'mainwindow.StatusDesChambres(page) 'Icon des chambres au niveau du dashboard
                    '-------------------------GESTION DES INFORMATIONS AGENCES ET INFORMATIONS DU CLIENT ------------------------------------------

                    GlobalVariable.DateDeTravail = Convert.ToDateTime(Functions.ObtenirDateDeTravail())

                    GlobalVariable.societe = Functions.allTableFields("societe")

                    GlobalVariable.codeAgence = table.Rows(0)("NUM_AGENCE")

                    GlobalVariable.AgenceActuelle = Functions.getElementByCode(GlobalVariable.codeAgence, "agence", "CODE_AGENCE")

                    GlobalVariable.ConnectedUser = table

                    'GESTION DES DROITS D'ACCES DE L'UTILISATEUR ACTUELEMENT CONNECTE
                    'LA GESTION DES DROITS IMPLIQUE L'ACTIVATION OU DEASCTION DES BOUTONS ET PANNEAUX

                    '1- GESTION DES MENUS A AFFICHER

                    Dim AccesUtilisateurActuel As DataTable = AccessRight.DroitAccesUtilisateurActuel(Trim(GlobalVariable.ConnectedUser(0)("CATEG_UTILISATEUR")))
                    GlobalVariable.DroitAccesDeUtilisateurConnect = AccesUtilisateurActuel

                    '---------------------------------------------------------------------------------------------------
                    'We keep the information of the current connected user


                    'get the user id
                    Dim ID_UTILISATEUR As Integer = Convert.ToInt32(table.Rows(0)(0))

                    'Make the User id Global on all classes and forms
                    GlobalVariable.idClient = ID_UTILISATEUR

                    'show the nex window form
                    'We determine if it is the first connexion by searching a society in database
                    Dim existQuery As String = "SELECT * From societe"

                    Dim commandCompany As New MySqlCommand(existQuery, GlobalVariable.connect)

                    Dim adapterCompany As New MySqlDataAdapter(commandCompany)
                    Dim tableCompany As New DataTable()
                    adapterCompany.Fill(tableCompany)

                    Dim NOM_USER As String = ""

                    If (tableCompany.Rows.Count > 0) Then

                        'MISE A ZERO DE TOUS CONCERNANT L'UTILISATEUR ACTUEL
                        Dim CODE_CAISSE As String = ""
                        Dim CODE_UTILISATEUR As String = GlobalVariable.ConnectedUser.Rows(0)("CODE_UTILISATEUR")

                        Dim ACTION As String = ""

                        If GlobalVariable.DroitAccesDeUtilisateurConnect.Rows.Count > 0 Then

                            If GlobalVariable.DroitAccesDeUtilisateurConnect.Rows(0)("GRANDE_CAISSE") = 1 Then

                                Dim CAISSE_UTILISATEUR As DataTable = Functions.getElementByCode(CODE_UTILISATEUR, "caisse", "CODE_UTILISATEUR")

                                If CAISSE_UTILISATEUR.Rows.Count > 0 Then

                                    CODE_CAISSE = CAISSE_UTILISATEUR.Rows(0)("CODE_CAISSE")

                                    Dim ETAT_CAISSE As Integer = 0
                                    Dim caissier As New Caisse()

                                    NOM_USER = GlobalVariable.ConnectedUser.Rows(0)("NOM_UTILISATEUR")

                                End If

                            End If

                        Else

                        End If

                        If GlobalVariable.actualLanguageValue = 0 Then
                            actionLanguage = "CONNEXION DE "
                        Else
                            actionLanguage = "LOGIN OF "
                        End If

                        ACTION = actionLanguage & NOM_USER

                        User.mouchard(ACTION)

                        '---------------------------------------------------------------------------------
                        HomeForm.Show()
                        HomeForm.TopMost = True
                        HomeForm.BringToFront()

                        Dim licenceInfo As DataTable = Functions.allTableFields("licence")
                        Dim licence As New Licence()

                        'SI ON TRAITE UNE LICENCE AUTRE QUE CELLE PAR DEFAUT ON DOIT EFFECTUER DES RETRANCHEMENTS

                        If licenceInfo.Rows.Count > 0 Then

                            If Not licenceInfo.Rows(0)("CODE_LICENCE") = "DEFAULT" Then
                                licence.reductionDeNombreDeDemarrageParDefaut(1, licenceInfo.Rows(0)("CODE_LICENCE"))
                            End If

                        End If

                    Else

                        Wizard.Close()
                        Wizard.Show()
                        Wizard.TopMost = True

                        Me.Close()

                    End If

                Else

                    Dim ACTION As String = ""


                    If GlobalVariable.actualLanguageValue = 1 Then 'FRENCH
                        languageMessage = "CODE UTILISATEUR ET/OU MOT DE PASS INVALIDE"
                        languageTitle = "Erreur de Connexion"
                        actionLanguage = "ECHEC DE TENTATIVE DE CONNEXION"
                    Else
                        languageMessage = "INVALIDE USER AND/OR PASSWORD"
                        languageTitle = "Login Error"
                        actionLanguage = "CONNECTION FAILURE"
                    End If

                    ACTION = actionLanguage

                    'User.mouchard(ACTION)

                    MessageBox.Show(languageMessage, languageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If

            End If

        Else

            Dim ACTION As String = ""

            If GlobalVariable.actualLanguageValue = 1 Then 'FRENCH
                languageMessage = "Bien vouloir remplir tous les champs"
                languageTitle = "Champ(s) vide(s)"
                actionLanguage = "ECHEC DE TENTATIVE DE CONNEXION"
            Else
                languageMessage = "Please fill all the field(s)"
                languageTitle = "Empty field(s)"
                actionLanguage = "CONNECTION FAILURE"
            End If

            ACTION = actionLanguage

            'User.mouchard(ACTION)

            MessageBox.Show(languageMessage, languageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub

    'Function to check empty fields
    Public Function verifyFields(ByVal operation As String) As Boolean

        Dim check As Boolean = False

        'if it is a login operation
        If (operation = "login") Then
            If (GunaLineTextBoxUsername.Text.Trim().Equals("") Or GunaLineTextBoxMotDePasse.Text.Trim().Equals("")) Then
                check = False
            Else
                check = True
            End If
        End If

        Return check

    End Function

    'minimizing the window
    Private Sub GunaImageButton2_Click(sender As Object, e As EventArgs) 
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'closing the window
    Private Sub GunaImageButton1_Click(sender As Object, e As EventArgs) 

        Me.Close()

        Application.ExitThread()

    End Sub

    ' We print the name of the current user when we loss focus on the user name input
    Private Sub GunaLineTextBoxUsername_Leave(sender As Object, e As EventArgs) Handles GunaLineTextBoxUsername.Leave

        Dim table As New DataTable()

        'Dim query As String = "SELECT * FROM utilisateurs WHERE CODE_UTILISATEUR=@CODE_UTILISATEUR AND NUM_AGENCE=@NUM_AGENCE"

        If GlobalVariable.databaseType = "MYSQL" Then

            Dim query As String = "SELECT * FROM utilisateurs WHERE CODE_UTILISATEUR=@CODE_UTILISATEUR"

            Dim command As New MySqlCommand(query, GlobalVariable.connect)

            command.Parameters.Add("@CODE_UTILISATEUR", MySqlDbType.VarChar).Value = GunaLineTextBoxUsername.Text
            command.Parameters.Add("@NUM_AGENCE", MySqlDbType.VarChar).Value = GlobalVariable.codeAgence

            table.Load(command.ExecuteReader())

            'connect.closeConnection()

        ElseIf GlobalVariable.databaseType = "ODBC" Or GlobalVariable.databaseType = "ACCESS" Then

            'Dim query As String = "SELECT * FROM utilisateurs WHERE CODE_UTILISATEUR=?"

            'Dim selCommand As New OdbcCommand(query, GlobalVariable.sqlConnection)
            'selCommand.Parameters.Add("@CODE_UTILISATEUR", OdbcType.VarChar).Value = GunaLineTextBoxUsername.Text
            'selCommand.Parameters.Add("@NUM_AGENCE", OdbcType.VarChar).Value = GlobalVariable.codeAgence

            'table.Load(selCommand.ExecuteReader())

        End If

        If (table.Rows.Count > 0) Then

            GunaLabelNomUtilisateur.ForeColor = Color.White
            GunaLabelNomUtilisateur.Visible = True
            GunaLabelNomUtilisateur.Text = table.Rows(0)("NOM_UTILISATEUR")
            GlobalVariable.userId = table.Rows(0)("ID_UTILISATEUR")
            GlobalVariable.ConnectedUser = Functions.getElementByCode(GlobalVariable.userId, "utilisateurs", "ID_UTILISATEUR")

        Else

            Dim languageMessage As String = ""

            If GlobalVariable.actualLanguageValue = 1 Then
                languageMessage = "Aucun n'utilisateur ne correspond !!"
            Else
                languageMessage = "No user corresponding !!"
            End If

            GunaLabelNomUtilisateur.Visible = True
            GunaLabelNomUtilisateur.Text = languageMessage
            GunaLabelNomUtilisateur.ForeColor = Color.Red

        End If

        'connect.closeConnection()

    End Sub

    Private Sub AccueilForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Functions.emptyConnectionVariable()
        Functions.EmtyGlobalVariablesContainingCodeToUpdate()

        GlobalVariable.databaseType = "MYSQL"
        GlobalVariable.softwareVersion = "lytesoftdb"
        'GlobalVariable.connecFunction()

        If GlobalVariable.databaseType = "MYSQL" Then
            GlobalVariable.connecFunction()
            'GlobalVariable.connect.OpenAsync()
        ElseIf GlobalVariable.databaseType = "ACCESS" Then
            'GlobalVariable.sqlConnection.OpenAsync()
        End If

        'GESTION DES LICENCES DU LOGICIELS

        'FONCTION POUR UNE SEULE AGENCE POUR LE MOMENT

        GlobalVariable.AgenceActuelle = Functions.allTableFields("agence")

        If GlobalVariable.AgenceActuelle.Rows.Count > 0 Then

            'LANGUE 
            Dim langue As New Languages()

            GlobalVariable.actualLanguageValue = GlobalVariable.AgenceActuelle.Rows(0)("LANGUE")
            langue.autoLoadLanguage(GunaComboBoxLangue, GlobalVariable.actualLanguageValue)

            GlobalVariable.defaultLanguage = GlobalVariable.AgenceActuelle.Rows(0)("LANGUE")

            'GunaComboBoxLangue.SelectedIndex = GlobalVariable.defaultLanguage
            GunaComboBoxLangue.SelectedIndex = 0

            langue.accueil(GlobalVariable.defaultLanguage)

            Dim doc As New Tarifs

            Dim dossierParentHotelSoft As String = GlobalVariable.AgenceActuelle.Rows(0)("CHEMIN_SAUVEGARDE_AUTO")

            Dim nomDuDossierRapport As String = "RAPPORTS"
            Dim nomDuDossierReservation As String = "RESERVATIONS"
            Dim nomDuDossierDataBase As String = "HSDB"

            'CREATION DES REPERTOIRES CLES

            doc.creationDeRepertoire(dossierParentHotelSoft & "\" & nomDuDossierRapport)
            doc.creationDeRepertoire(dossierParentHotelSoft & "\" & nomDuDossierReservation)
            doc.creationDeRepertoire(dossierParentHotelSoft & "\" & nomDuDossierDataBase)

        End If

        Dim licence As New Licence()

        'CREATION DE LA TABLE DES GEATION DE LICENCE SI ELLE N.EXISTE PAS
        licence.creationDeLaTableDeLicence()

        licence.gestionDesLicence()

        If ActivationForm.Visible Then

        End If

        Functions.insertionDuNumeroDeCompteDansLesFacturesNePossedantPas()
        Functions.RetablissementDesResteAPayerNegatifEnPositif()

    End Sub

    'VERSION OF THE SOFTWARE
    Private Sub GunaCheckBoxVersion_Click(sender As Object, e As EventArgs) Handles GunaCheckBoxVersion.Click

        Dim language As New Languages()

        language.autoLoadVersionLanguage(GlobalVariable.actualLanguageValue)

        If GunaCheckBoxVersion.Checked Then

            GunaLineTextBoxUsername.Clear()
            GunaLineTextBoxMotDePasse.Clear()
            GunaLabelNomUtilisateur.Visible = False

            GunaComboBoxVersion.Visible = True
            GunaLabelVersion.Visible = True

            If GunaComboBoxVersion.Items.Count = 2 Then
                GunaComboBoxVersion.SelectedIndex = 1
            End If

            GlobalVariable.softwareVersion = "lytesoftdbdemo"

            GlobalVariable.connecFunction()

        Else

            GunaComboBoxVersion.Visible = False
            GunaLabelVersion.Visible = False

            If GunaComboBoxVersion.Items.Count > 0 Then
                GunaComboBoxVersion.SelectedIndex = 0
            End If

            GlobalVariable.softwareVersion = "lytesoftdb"

            GlobalVariable.connecFunction()

        End If

        GunaLabelNomUtilisateur.Text = ""
        GunaLineTextBoxUsername.Clear()
        GunaLineTextBoxMotDePasse.Clear()

    End Sub

    Private Sub GunaComboBoxVersion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GunaComboBoxVersion.SelectedIndexChanged

        If GunaComboBoxVersion.SelectedIndex = 1 Then
            GlobalVariable.softwareVersion = "lytesoftdbdemo"
        ElseIf GunaComboBoxVersion.SelectedIndex = 0 Then
            GlobalVariable.softwareVersion = "lytesoftdb"
        End If

    End Sub

    Private Sub GunaComboBoxLangue_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GunaComboBoxLangue.SelectedIndexChanged

        'LANGUE

        'Dim selectedLanguage As Integer

        'If False Then

        'If GunaComboBoxLangue.SelectedIndex >= 0 Then

        'selectedLanguage = GunaComboBoxLangue.SelectedIndex

        'If Not (selectedLanguage = GlobalVariable.actualLanguageValue) Then

        'GlobalVariable.actualLanguageValue = selectedLanguage

        'Dim langue As New Languages()

        'Dim languageValue As Integer = GunaComboBoxLangue.SelectedIndex

        'langue.autoLoadLanguage(GunaComboBoxLangue, languageValue)

        'GunaComboBoxLangue.SelectedIndex = selectedLanguage

        'langue.accueil(languageValue)

        'End If

        'End If

        'End If



    End Sub

    Private Sub GunaButtonOuvrirSession_KeyDown(sender As Object, e As KeyEventArgs) Handles GunaLineTextBoxMotDePasse.KeyDown

        If e.KeyCode = Keys.Enter Then

            Dim premiereConnexion As Boolean = True

            Dim loginQuery As String = ""

            If GlobalVariable.databaseType = "MYSQL" Then
                loginQuery = "SELECT * FROM utilisateurs WHERE CODE_UTILISATEUR = @CODE_UTILISATEUR AND PASSWORD_UTILISATEUR = @PASSWORD_UTILISATEUR"
            ElseIf GlobalVariable.databaseType = "ODBC" Or GlobalVariable.databaseType = "ACCESS" Then
                loginQuery = "SELECT * FROM utilisateurs WHERE CODE_UTILISATEUR = ? AND PASSWORD_UTILISATEUR = ?"
            End If

            Dim table As New DataTable()

            Dim languageMessage As String = ""
            Dim languageTitle As String = ""
            Dim actionLanguage As String = ""

            If (verifyFields("login")) Then

                If GlobalVariable.databaseType = "MYSQL" Then

                    Dim command As MySqlCommand

                    command = New MySqlCommand(loginQuery, GlobalVariable.connect)
                    command.Parameters.Add("@CODE_UTILISATEUR", MySqlDbType.VarChar).Value = GunaLineTextBoxUsername.Text
                    command.Parameters.Add("@PASSWORD_UTILISATEUR", MySqlDbType.VarChar).Value = GunaLineTextBoxMotDePasse.Text

                    table.Load(command.ExecuteReader())

                ElseIf GlobalVariable.databaseType = "ODBC" Or GlobalVariable.databaseType = "ACCESS" Then

                    'Dim selCommand As New OdbcCommand(loginQuery, GlobalVariable.sqlConnection)
                    'selCommand.Parameters.Add("@CODE_UTILISATEUR", OdbcType.VarChar).Value = GunaLineTextBoxUsername.Text
                    'selCommand.Parameters.Add("@PASSWORD_UTILISATEUR", OdbcType.VarChar).Value = GunaLineTextBoxMotDePasse.Text

                    'Dim reader As OdbcDataReader = selCommand.ExecuteReader()

                    'table.Load(reader)

                End If

                Dim client As String = ""

                If table.Rows.Count > 0 Then
                    client = table.Rows(0)("NOM_UTILISATEUR")
                End If

                If Trim(client.ToUpper()).Equals("CLIENT") Then

                    If table.Rows.Count > 0 Then

                        GlobalVariable.DateDeTravail = Convert.ToDateTime(Functions.ObtenirDateDeTravail())

                        GlobalVariable.societe = Functions.allTableFields("societe")

                        GlobalVariable.codeAgence = table.Rows(0)("NUM_AGENCE")

                        GlobalVariable.AgenceActuelle = Functions.getElementByCode(GlobalVariable.codeAgence, "agence", "CODE_AGENCE")

                        GlobalVariable.ConnectedUser = table

                    End If

                    CustomCommandForm.Show()
                    Me.Close()

                Else

                    If table.Rows.Count > 0 Then

                        'Dim page As Integer = 1
                        'Dim mainwindow As New MainWindow()
                        'MainWindow.StatusDesChambres(page) 'Icon des chambres au niveau du dashboard
                        '-------------------------GESTION DES INFORMATIONS AGENCES ET INFORMATIONS DU CLIENT ------------------------------------------

                        GlobalVariable.DateDeTravail = Convert.ToDateTime(Functions.ObtenirDateDeTravail())

                        GlobalVariable.societe = Functions.allTableFields("societe")

                        GlobalVariable.codeAgence = table.Rows(0)("NUM_AGENCE")

                        GlobalVariable.AgenceActuelle = Functions.getElementByCode(GlobalVariable.codeAgence, "agence", "CODE_AGENCE")

                        GlobalVariable.ConnectedUser = table

                        'GESTION DES DROITS D'ACCES DE L'UTILISATEUR ACTUELEMENT CONNECTE
                        'LA GESTION DES DROITS IMPLIQUE L'ACTIVATION OU DEASCTION DES BOUTONS ET PANNEAUX

                        '1- GESTION DES MENUS A AFFICHER

                        Dim AccesUtilisateurActuel As DataTable = AccessRight.DroitAccesUtilisateurActuel(Trim(GlobalVariable.ConnectedUser(0)("CATEG_UTILISATEUR")))
                        GlobalVariable.DroitAccesDeUtilisateurConnect = AccesUtilisateurActuel

                        '---------------------------------------------------------------------------------------------------
                        'We keep the information of the current connected user


                        'get the user id
                        Dim ID_UTILISATEUR As Integer = Convert.ToInt32(table.Rows(0)(0))

                        'Make the User id Global on all classes and forms
                        GlobalVariable.idClient = ID_UTILISATEUR

                        'show the nex window form
                        'We determine if it is the first connexion by searching a society in database
                        Dim existQuery As String = "SELECT * From societe"

                        Dim commandCompany As New MySqlCommand(existQuery, GlobalVariable.connect)

                        Dim adapterCompany As New MySqlDataAdapter(commandCompany)
                        Dim tableCompany As New DataTable()
                        adapterCompany.Fill(tableCompany)

                        Dim NOM_USER As String = ""

                        If (tableCompany.Rows.Count > 0) Then

                            'MISE A ZERO DE TOUS CONCERNANT L'UTILISATEUR ACTUEL
                            Dim CODE_CAISSE As String = ""
                            Dim CODE_UTILISATEUR As String = GlobalVariable.ConnectedUser.Rows(0)("CODE_UTILISATEUR")

                            Dim ACTION As String = ""

                            If GlobalVariable.DroitAccesDeUtilisateurConnect.Rows.Count > 0 Then

                                If GlobalVariable.DroitAccesDeUtilisateurConnect.Rows(0)("GRANDE_CAISSE") = 1 Then

                                    Dim CAISSE_UTILISATEUR As DataTable = Functions.getElementByCode(CODE_UTILISATEUR, "caisse", "CODE_UTILISATEUR")

                                    If CAISSE_UTILISATEUR.Rows.Count > 0 Then

                                        CODE_CAISSE = CAISSE_UTILISATEUR.Rows(0)("CODE_CAISSE")

                                        Dim ETAT_CAISSE As Integer = 0
                                        Dim caissier As New Caisse()

                                        NOM_USER = GlobalVariable.ConnectedUser.Rows(0)("NOM_UTILISATEUR")

                                    End If

                                End If

                            Else

                            End If

                            If GlobalVariable.actualLanguageValue = 0 Then
                                actionLanguage = "CONNEXION DE "
                            Else
                                actionLanguage = "LOGIN OF "
                            End If

                            ACTION = actionLanguage & NOM_USER

                            User.mouchard(ACTION)

                            '---------------------------------------------------------------------------------
                            HomeForm.Show()
                            HomeForm.TopMost = True
                            HomeForm.BringToFront()

                            Dim licenceInfo As DataTable = Functions.allTableFields("licence")
                            Dim licence As New Licence()

                            'SI ON TRAITE UNE LICENCE AUTRE QUE CELLE PAR DEFAUT ON DOIT EFFECTUER DES RETRANCHEMENTS

                            If licenceInfo.Rows.Count > 0 Then

                                If Not licenceInfo.Rows(0)("CODE_LICENCE") = "DEFAULT" Then
                                    licence.reductionDeNombreDeDemarrageParDefaut(1, licenceInfo.Rows(0)("CODE_LICENCE"))
                                End If

                            End If

                        Else

                            Wizard.Close()
                            Wizard.Show()
                            Wizard.TopMost = True

                            Me.Close()

                        End If

                    Else

                        Dim ACTION As String = ""


                        If GlobalVariable.actualLanguageValue = 1 Then 'FRENCH
                            languageMessage = "CODE UTILISATEUR ET/OU MOT DE PASS INVALIDE"
                            languageTitle = "Erreur de Connexion"
                            actionLanguage = "ECHEC DE TENTATIVE DE CONNEXION"
                        Else
                            languageMessage = "INVALIDE USER AND/OR PASSWORD"
                            languageTitle = "Login Error"
                            actionLanguage = "CONNECTION FAILURE"
                        End If

                        ACTION = actionLanguage

                        'User.mouchard(ACTION)

                        MessageBox.Show(languageMessage, languageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    End If

                End If

            Else

                Dim ACTION As String = ""

                If GlobalVariable.actualLanguageValue = 1 Then 'FRENCH
                    languageMessage = "Bien vouloir remplir tous les champs"
                    languageTitle = "Champ(s) vide(s)"
                    actionLanguage = "ECHEC DE TENTATIVE DE CONNEXION"
                Else
                    languageMessage = "Please fill all the field(s)"
                    languageTitle = "Empty field(s)"
                    actionLanguage = "CONNECTION FAILURE"
                End If

                ACTION = actionLanguage

                'User.mouchard(ACTION)

                MessageBox.Show(languageMessage, languageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If

        End If


    End Sub

End Class
