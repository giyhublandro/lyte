Public Class HomeForm

    Private Sub GunaImageButton1_Click(sender As Object, e As EventArgs) Handles GunaImageButtonClose.Click
        Application.ExitThread()
    End Sub

    Private Sub GunaImageButtonMinimized_Click(sender As Object, e As EventArgs) Handles GunaImageButtonMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'MODULE RESERVATION
    Private Sub reception_Click(sender As Object, e As EventArgs) Handles GunaButtonReservation.Click, GunaButtonMenuReservation.Click

        Me.Cursor = Cursors.WaitCursor

        MainWindow.TabControlHbergement.SelectedIndex = 1

        MainWindow.PanelEnregistrement.Show()

        MainWindow.PanelTableauDeBords.Hide()

        MainWindow.Show()

        Me.Close()

        Me.Cursor = Cursors.Default

    End Sub

    'MODULE RECEPTION
    Private Sub GunaButtonMenuReception_Click(sender As Object, e As EventArgs) Handles GunaButtonMenuReception.Click

        Me.Cursor = Cursors.WaitCursor

        GlobalVariable.affichageDuStatutsDesCahmbresOuPas = False

        MainWindow.PanelTableauDeBords.Show()

        MainWindow.PanelEnregistrement.Hide()

        MainWindow.Show()

        'choixDeMagasinOuPas()

        Me.Close()

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub GunaButtonLectureDeCarte_Click(sender As Object, e As EventArgs)

        Me.Cursor = Cursors.WaitCursor

        MainWindow.PanelTableauDeBords.Hide()

        MainWindow.PanelEnregistrement.Show()

        MainWindow.Show()

        MainWindow.LectureDeCarte()

        Me.Close()

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub GunaButtonServiceEtage_Click(sender As Object, e As EventArgs) Handles GunaButtonServiceEtage.Click, GunaButtonMenuService.Click

        Me.Cursor = Cursors.WaitCursor

        GlobalVariable.typeChambreOuSalle = "chambre"

        MainWindowServiceEtageForm.TabControlRoomForm.SelectedIndex = 6
        MainWindowServiceEtageForm.LabelLibelleActif.Text = "NETTOYAGE DES CHAMBRES"
        MainWindowServiceEtageForm.Visible = True

        Me.Close()

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub GunaButtonBarResturant_Click(sender As Object, e As EventArgs) Handles GunaButtonBarResturant.Click

        Me.Cursor = Cursors.WaitCursor

        BarRestaurantForm.GunaLabelHeader.Text = "COMPTOIR"
        GlobalVariable.typeDeClientAFacturer = "comptoir"
        BarRestaurantForm.Show()

        Me.Close()

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub GunaButtonCompatbilite_Click(sender As Object, e As EventArgs) Handles GunaButtonCompatbilite.Click

        Me.Cursor = Cursors.WaitCursor
        MainWindowComptabiliteForm.TabControlComptabilite.SelectedIndex = 1
        MainWindowComptabiliteForm.Show()
        Me.Close()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub GunaButtonEconomat_Click(sender As Object, e As EventArgs) Handles GunaButtonEconomat.Click

        Me.Cursor = Cursors.WaitCursor
        MainWindowEconomat.Show()

        Me.Close()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim languages As New Languages()

        languages.home(GlobalVariable.actualLanguageValue)

        'AccueilForm.Hide()
        AccueilForm.Close()

        'On vérifie si on a des droit
        'Si oui
        If GlobalVariable.DroitAccesDeUtilisateurConnect.Rows.Count > 0 Then

            If GlobalVariable.DroitAccesDeUtilisateurConnect.Rows(0)("MENU_RESERVATION") = 0 Then
                GunaButtonMenuReservation.Enabled = False
                GunaButtonReservation.Enabled = False
            End If

            If GlobalVariable.DroitAccesDeUtilisateurConnect.Rows(0)("MENU_RECEPTION") = 0 Then
                GunaButtonMenuReception.Enabled = False
                GunaButtonMenuReception.Enabled = False
            End If

            If GlobalVariable.DroitAccesDeUtilisateurConnect.Rows(0)("MENU_ECONOMAT") = 0 Then
                GunaButtonMenuEconomat.Enabled = False
                GunaButtonEconomat.Enabled = False
            End If

            If GlobalVariable.DroitAccesDeUtilisateurConnect.Rows(0)("MENU_SERVICE_ETAGE") = 0 Then
                GunaButtonMenuService.Enabled = False
                GunaButtonServiceEtage.Enabled = False
            End If

            If GlobalVariable.DroitAccesDeUtilisateurConnect.Rows(0)("MENU_BAR_RESTAURANT") = 0 Then
                GunaButtonMenuBarRestaurant.Enabled = False
                GunaButtonBarResturant.Enabled = False
            End If

            If GlobalVariable.DroitAccesDeUtilisateurConnect.Rows(0)("MENU_COMPTABILITE") = 0 Then
                GunaButtonMenuComptabilite.Enabled = False
                GunaButtonCompatbilite.Enabled = False
            End If

            If GlobalVariable.DroitAccesDeUtilisateurConnect.Rows(0)("MENU_TECHNIQUE") = 0 Then
                GunaButtonTechnique.Enabled = False
            End If

            If GlobalVariable.DroitAccesDeUtilisateurConnect.Rows(0)("MENU_CUISINE") = 0 Then
                GunaButtonCuisine.Enabled = False
            End If

        End If

        AccueilForm.Close()

    End Sub

    Private Sub GunaButton45_Click(sender As Object, e As EventArgs) Handles GunaButtonAccueil.Click


    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButtonMenuTechnique.Click

        Me.Cursor = Cursors.WaitCursor
        MainWindowTechnique.Visible = True

        Me.Visible = False

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub GunaButtonReception_Click(sender As Object, e As EventArgs) Handles GunaButtonReception.Click

        Me.Cursor = Cursors.WaitCursor

        MainWindow.TabControlHbergement.SelectedIndex = 0

        MainWindow.PanelEnregistrement.Hide()

        GlobalVariable.affichageDuStatutsDesCahmbresOuPas = True

        MainWindow.PanelTableauDeBords.Show()

        MainWindow.Show()

        Me.Close()

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub GunaButtonCuisine_Click(sender As Object, e As EventArgs) Handles GunaButtonCuisine.Click

        Me.Cursor = Cursors.WaitCursor

        MainWindowCuisineForm.Show()

        Me.Close()

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub GunaButton46_Click(sender As Object, e As EventArgs) Handles GunaButtonTechnique.Click

        Me.Cursor = Cursors.WaitCursor
        MainWindowTechnique.Visible = True

        Me.Close()

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub GunaButtonCusine_Click(sender As Object, e As EventArgs) Handles GunaButtonCusine.Click
        Me.Cursor = Cursors.WaitCursor

        MainWindowCuisineForm.Show()
        ArticleForm.Show()

        ArticleForm.Location = New Point(90, 110)
        ArticleForm.TopMost = True

        Me.Close()

        Me.Cursor = Cursors.Default
    End Sub

End Class
