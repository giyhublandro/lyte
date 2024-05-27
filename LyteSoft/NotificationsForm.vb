﻿Imports MySql.Data.MySqlClient

Public Class NotificationsForm

    Private Sub NotificationsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Profil
        Dim profils As String = "SELECT CODE_PROFIL, NOM_PROFIL FROM utilisateur_acces ORDER BY NOM_PROFIL ASC"
        Dim commandprofilsList As New MySqlCommand(profils, GlobalVariable.connect)

        Dim adapterprofilsList As New MySqlDataAdapter(commandprofilsList)
        Dim tableprofilsList As New DataTable()
        adapterprofilsList.Fill(tableprofilsList)

        If (tableprofilsList.Rows.Count > 0) Then

            GunaComboBoxProfilUtilisateur.DataSource = tableprofilsList
            GunaComboBoxProfilUtilisateur.ValueMember = "CODE_PROFIL"
            GunaComboBoxProfilUtilisateur.DisplayMember = "NOM_PROFIL"

        End If

        messageNonLus()

        GunaDataGridViewNotification.Visible = True

    End Sub

    Private Sub GunaFermer_Click(sender As Object, e As EventArgs) Handles GunaFermer.Click
        Me.Close()
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        GunaLabelNomDuNettoyeur.Text = "ENVOYER UN MESSAGE"

        GunaComboBoxProfilUtilisateur.Visible = True
        GunaButtonEnvoyer.Text = "Envoyer"
        GunaPanelEcrire.BringToFront()
        GunaPanelEcrire.Visible = True

        Functions.SiplifiedClearTextBox(Me)

    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click

        GunaLabelNomDuNettoyeur.Text = "BOITE DE RECEPTION"

        GunaDataGridViewNotification.Columns.Clear()

        GunaPanelLire.BringToFront()
        GunaPanelLire.Visible = True

        Dim notifications As DataTable = Functions.GetAllElementsOnCondition(GlobalVariable.ConnectedUser.Rows(0)("CATEG_UTILISATEUR"), "notification", "CODE_PROFIL")

        If notifications.Rows.Count > 0 Then

            GunaDataGridViewNotification.DataSource = notifications

            GunaDataGridViewNotification.Columns("ID_NOTIFICATION").Visible = False
            GunaDataGridViewNotification.Columns("CODE_PROFIL").Visible = False
            GunaDataGridViewNotification.Columns("CODE_AGENCE").Visible = False
            GunaDataGridViewNotification.Columns("ETAT_NOTIFCATION").Visible = False

        Else

        End If

        GunaPanelLire.BringToFront()
        GunaPanelLire.Visible = True

    End Sub

    'Envoyer un message
    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles GunaButtonEnvoyer.Click

        Dim sendMessage As New User()

        Dim CODE_PROFIL As String = GunaComboBoxProfilUtilisateur.SelectedValue
        Dim MESSAGE As String = GunaTextBoxMessage.Text
        Dim OBJET As String = GunaTextBoxObjet.Text
        Dim EXPEDITEUR As String = GlobalVariable.ConnectedUser.Rows(0)("CATEG_UTILISATEUR")
        Dim DATE_ENVOI As Date = Date.Now()

        sendMessage.sendMessage(CODE_PROFIL, MESSAGE, OBJET, DATE_ENVOI, EXPEDITEUR)

        If Trim(GunaButtonEnvoyer.Text) = "Envoyer" Then

        Else
            GunaButtonEnvoyer.Text = "Envoyer"
        End If

        MessageBox.Show("Message envoyé avec succès", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Functions.SiplifiedClearTextBox(Me)

    End Sub

    'Affichage du message
    Private Sub GunaDataGridViewNotification_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridViewNotification.CellDoubleClick

        If e.RowIndex >= 0 Then

            Dim userMessage As New User()

            Dim row As DataGridViewRow

            row = Me.GunaDataGridViewNotification.Rows(e.RowIndex)

            Dim ID_NOTIFICATION As Integer = row.Cells("ID_NOTIFICATION").Value.ToString

            Dim ETAT As Integer = 1

            userMessage.updateMessageState(ID_NOTIFICATION, ETAT)

            GunaLabelNomDuNettoyeur.Text = "MESSAGE ENVOYE PAR " & row.Cells("CODE_PROFIL").Value.ToString

            GunaComboBoxProfilUtilisateur.SelectedValue = row.Cells("EXPEDITEUR").Value.ToString

            GunaComboBoxProfilUtilisateur.Visible = True

            GunaTextBoxObjet.Text = row.Cells("OBJET").Value.ToString

            GunaTextBoxMessage.Text = row.Cells("MESSAGE").Value.ToString

            GunaButtonEnvoyer.Text = "Répondre"

            GunaPanelEcrire.BringToFront()

            GunaPanelEcrire.Visible = True

            Dim notifications As DataTable = Functions.GetAllElementsOnTwoConditions(GlobalVariable.ConnectedUser.Rows(0)("CATEG_UTILISATEUR"), "notification", "CODE_PROFIL", 0, "ETAT_NOTIFCATION")

            If Trim(GunaTextBoxFromWhichWindow.Text).Equals("economat") Then

                If notifications.Rows.Count > 0 Then
                    MainWindowEconomat.GunaLabelNotification.Text = "(" & notifications.Rows.Count & ")"
                Else
                    MainWindowEconomat.GunaLabelNotification.Text = "(" & 0 & ")"
                End If

            ElseIf Trim(GunaTextBoxFromWhichWindow.Text).Equals("cuisine") Then
                If notifications.Rows.Count > 0 Then
                    MainWindowCuisineForm.GunaLabelNotification.Text = "(" & notifications.Rows.Count & ")"
                Else
                    MainWindowCuisineForm.GunaLabelNotification.Text = "(" & 0 & ")"
                End If
            ElseIf Trim(GunaTextBoxFromWhichWindow.Text).Equals("reception") Then
                If notifications.Rows.Count > 0 Then
                    MainWindow.StatusBarPanelNotification.Text = "(" & notifications.Rows.Count & ")"
                Else
                    MainWindow.StatusBarPanelNotification.Text = "(" & 0 & ")"
                End If
            ElseIf Trim(GunaTextBoxFromWhichWindow.Text).Equals("bar") Then
                If notifications.Rows.Count > 0 Then
                    BarRestaurantForm.GunaLabelNotification.Text = "(" & notifications.Rows.Count & ")"
                Else
                    BarRestaurantForm.GunaLabelNotification.Text = "(" & 0 & ")"
                End If
            ElseIf Trim(GunaTextBoxFromWhichWindow.Text).Equals("etage") Then
                If notifications.Rows.Count > 0 Then
                    MainWindowServiceEtageForm.GunaLabelNotification.Text = "(" & notifications.Rows.Count & ")"
                Else
                    MainWindowServiceEtageForm.GunaLabelNotification.Text = "(" & 0 & ")"
                End If
            ElseIf Trim(GunaTextBoxFromWhichWindow.Text).Equals("finance") Then
                If notifications.Rows.Count > 0 Then
                    MainWindowComptabiliteForm.GunaLabelNotification.Text = "(" & notifications.Rows.Count & ")"
                Else
                    MainWindowComptabiliteForm.GunaLabelNotification.Text = "(" & 0 & ")"
                End If
            ElseIf Trim(GunaTextBoxFromWhichWindow.Text).Equals("technique") Then
                If notifications.Rows.Count > 0 Then
                    MainWindowTechnique.GunaLabelNotification.Text = "(" & notifications.Rows.Count & ")"
                Else
                    MainWindowTechnique.GunaLabelNotification.Text = "(" & 0 & ")"
                End If
            End If

        End If

    End Sub

    'MESSAGE LUS
    Private Sub GunaButtonMessageLus_Click(sender As Object, e As EventArgs) Handles GunaButtonMessageLus.Click

        GunaDataGridViewNotification.Columns.Clear()

        GunaLabelNomDuNettoyeur.Text = "BOITE DE RECEPTION : MESSAGES LUS"
        GunaPanelLire.BringToFront()
        GunaPanelLire.Visible = True

        Dim notifications As DataTable = Functions.GetAllElementsOnTwoConditions(GlobalVariable.ConnectedUser.Rows(0)("CATEG_UTILISATEUR"), "notification", "CODE_PROFIL", 1, "ETAT_NOTIFCATION")

        If notifications.Rows.Count > 0 Then

            GunaDataGridViewNotification.DataSource = notifications

            GunaDataGridViewNotification.Columns("ID_NOTIFICATION").Visible = False
            GunaDataGridViewNotification.Columns("CODE_PROFIL").Visible = False
            GunaDataGridViewNotification.Columns("CODE_AGENCE").Visible = False
            GunaDataGridViewNotification.Columns("ETAT_NOTIFCATION").Visible = False

        End If

    End Sub

    'MEssage NON LUS
    Private Sub GunaButtonMessageNonLus_Click(sender As Object, e As EventArgs) Handles GunaButtonMessageNonLus.Click

        messageNonLus()

    End Sub


    Private Sub messageNonLus()


        GunaDataGridViewNotification.Columns.Clear()

        GunaLabelNomDuNettoyeur.Text = "BOITE DE RECEPTION : MESSAGES NON LUS"
        GunaPanelLire.BringToFront()
        GunaPanelLire.Visible = True

        Dim notifications As DataTable = Functions.GetAllElementsOnTwoConditions(GlobalVariable.ConnectedUser.Rows(0)("CATEG_UTILISATEUR"), "notification", "CODE_PROFIL", 0, "ETAT_NOTIFCATION")

        If notifications.Rows.Count > 0 Then

            GunaLabelNomDuNettoyeur.Text = "BOITE DE RECEPTION : MESSAGES NON LUS " & "(" & notifications.Rows.Count & ")"

            GunaDataGridViewNotification.DataSource = notifications

            GunaDataGridViewNotification.Columns("ID_NOTIFICATION").Visible = False
            GunaDataGridViewNotification.Columns("CODE_PROFIL").Visible = False
            GunaDataGridViewNotification.Columns("CODE_AGENCE").Visible = False
            GunaDataGridViewNotification.Columns("ETAT_NOTIFCATION").Visible = False

        Else

            GunaLabelNomDuNettoyeur.Text = "BOITE DE RECEPTION "

        End If

        GunaPanelLire.BringToFront()
        GunaPanelLire.Visible = True

    End Sub
End Class