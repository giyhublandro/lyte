<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccueilForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation4 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccueilForm))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBoxRights = New System.Windows.Forms.TextBox()
        Me.GunaComboBoxLangue = New Guna.UI.WinForms.GunaComboBox()
        Me.PanelConnexion = New System.Windows.Forms.Panel()
        Me.GunaButtonActivation = New Guna.UI.WinForms.GunaButton()
        Me.GunaButtonOuvrirSession = New Guna.UI.WinForms.GunaButton()
        Me.GunaPanelFormTop = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabelNomUtilisateur = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabelUsername = New Guna.UI.WinForms.GunaLabel()
        Me.GunaCheckBoxVersion = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaLineTextBoxUsername = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaComboBoxVersion = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaButtonAnnulerAccueil = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabelVersion = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLineTextBoxMotDePasse = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabelPwd = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabelUser = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaTransitionAnimation = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.PanelConnexion.SuspendLayout()
        Me.GunaPanelFormTop.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaTransitionAnimation.SetDecoration(Me.TextBox1, Guna.UI.Animation.DecorationType.None)
        Me.TextBox1.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(14, 240)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(433, 23)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "CONTACT: 693-53-48-44"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxRights
        '
        Me.TextBoxRights.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBoxRights.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaTransitionAnimation.SetDecoration(Me.TextBoxRights, Guna.UI.Animation.DecorationType.None)
        Me.TextBoxRights.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRights.ForeColor = System.Drawing.Color.Black
        Me.TextBoxRights.Location = New System.Drawing.Point(19, 222)
        Me.TextBoxRights.Multiline = True
        Me.TextBoxRights.Name = "TextBoxRights"
        Me.TextBoxRights.Size = New System.Drawing.Size(433, 23)
        Me.TextBoxRights.TabIndex = 8
        Me.TextBoxRights.Text = "Copyrights TECHFLECTION  2024 Tous droits réservés"
        Me.TextBoxRights.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaComboBoxLangue
        '
        Me.GunaComboBoxLangue.BackColor = System.Drawing.Color.Transparent
        Me.GunaComboBoxLangue.BaseColor = System.Drawing.Color.White
        Me.GunaComboBoxLangue.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaComboBoxLangue.BorderSize = 1
        Me.GunaTransitionAnimation.SetDecoration(Me.GunaComboBoxLangue, Guna.UI.Animation.DecorationType.None)
        Me.GunaComboBoxLangue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GunaComboBoxLangue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GunaComboBoxLangue.FocusedColor = System.Drawing.Color.Empty
        Me.GunaComboBoxLangue.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaComboBoxLangue.ForeColor = System.Drawing.Color.Black
        Me.GunaComboBoxLangue.FormattingEnabled = True
        Me.GunaComboBoxLangue.ItemHeight = 18
        Me.GunaComboBoxLangue.Location = New System.Drawing.Point(155, 159)
        Me.GunaComboBoxLangue.Name = "GunaComboBoxLangue"
        Me.GunaComboBoxLangue.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaComboBoxLangue.OnHoverItemForeColor = System.Drawing.Color.White
        Me.GunaComboBoxLangue.Radius = 3
        Me.GunaComboBoxLangue.Size = New System.Drawing.Size(160, 24)
        Me.GunaComboBoxLangue.TabIndex = 6
        '
        'PanelConnexion
        '
        Me.PanelConnexion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelConnexion.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PanelConnexion.Controls.Add(Me.GunaButtonActivation)
        Me.PanelConnexion.Controls.Add(Me.TextBox1)
        Me.PanelConnexion.Controls.Add(Me.GunaButtonOuvrirSession)
        Me.PanelConnexion.Controls.Add(Me.GunaPanelFormTop)
        Me.PanelConnexion.Controls.Add(Me.TextBoxRights)
        Me.PanelConnexion.Controls.Add(Me.GunaCheckBoxVersion)
        Me.PanelConnexion.Controls.Add(Me.GunaLineTextBoxUsername)
        Me.PanelConnexion.Controls.Add(Me.GunaComboBoxVersion)
        Me.PanelConnexion.Controls.Add(Me.GunaButtonAnnulerAccueil)
        Me.PanelConnexion.Controls.Add(Me.GunaLabelVersion)
        Me.PanelConnexion.Controls.Add(Me.GunaLineTextBoxMotDePasse)
        Me.PanelConnexion.Controls.Add(Me.GunaComboBoxLangue)
        Me.PanelConnexion.Controls.Add(Me.GunaLabelPwd)
        Me.PanelConnexion.Controls.Add(Me.GunaLabelUser)
        Me.PanelConnexion.Controls.Add(Me.GunaLabel6)
        Me.GunaTransitionAnimation.SetDecoration(Me.PanelConnexion, Guna.UI.Animation.DecorationType.None)
        Me.PanelConnexion.Location = New System.Drawing.Point(-2, 217)
        Me.PanelConnexion.Name = "PanelConnexion"
        Me.PanelConnexion.Size = New System.Drawing.Size(465, 260)
        Me.PanelConnexion.TabIndex = 5
        '
        'GunaButtonActivation
        '
        Me.GunaButtonActivation.AnimationHoverSpeed = 0.07!
        Me.GunaButtonActivation.AnimationSpeed = 0.03!
        Me.GunaButtonActivation.BackColor = System.Drawing.Color.Transparent
        Me.GunaButtonActivation.BaseColor = System.Drawing.Color.White
        Me.GunaButtonActivation.BorderColor = System.Drawing.Color.Black
        Me.GunaTransitionAnimation.SetDecoration(Me.GunaButtonActivation, Guna.UI.Animation.DecorationType.None)
        Me.GunaButtonActivation.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButtonActivation.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButtonActivation.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButtonActivation.ForeColor = System.Drawing.Color.Black
        Me.GunaButtonActivation.Image = Nothing
        Me.GunaButtonActivation.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonActivation.Location = New System.Drawing.Point(166, 189)
        Me.GunaButtonActivation.Name = "GunaButtonActivation"
        Me.GunaButtonActivation.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButtonActivation.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButtonActivation.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonActivation.OnHoverImage = Nothing
        Me.GunaButtonActivation.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonActivation.Radius = 4
        Me.GunaButtonActivation.Size = New System.Drawing.Size(138, 27)
        Me.GunaButtonActivation.TabIndex = 5
        Me.GunaButtonActivation.Text = "Activation"
        Me.GunaButtonActivation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButtonActivation.Visible = False
        '
        'GunaButtonOuvrirSession
        '
        Me.GunaButtonOuvrirSession.AnimationHoverSpeed = 0.07!
        Me.GunaButtonOuvrirSession.AnimationSpeed = 0.03!
        Me.GunaButtonOuvrirSession.BackColor = System.Drawing.Color.Transparent
        Me.GunaButtonOuvrirSession.BaseColor = System.Drawing.Color.White
        Me.GunaButtonOuvrirSession.BorderColor = System.Drawing.Color.Black
        Me.GunaTransitionAnimation.SetDecoration(Me.GunaButtonOuvrirSession, Guna.UI.Animation.DecorationType.None)
        Me.GunaButtonOuvrirSession.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButtonOuvrirSession.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButtonOuvrirSession.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButtonOuvrirSession.ForeColor = System.Drawing.Color.Black
        Me.GunaButtonOuvrirSession.Image = Nothing
        Me.GunaButtonOuvrirSession.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonOuvrirSession.Location = New System.Drawing.Point(9, 205)
        Me.GunaButtonOuvrirSession.Name = "GunaButtonOuvrirSession"
        Me.GunaButtonOuvrirSession.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButtonOuvrirSession.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButtonOuvrirSession.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonOuvrirSession.OnHoverImage = Nothing
        Me.GunaButtonOuvrirSession.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonOuvrirSession.Radius = 4
        Me.GunaButtonOuvrirSession.Size = New System.Drawing.Size(138, 15)
        Me.GunaButtonOuvrirSession.TabIndex = 3
        Me.GunaButtonOuvrirSession.Text = "Ouvrir une Session"
        Me.GunaButtonOuvrirSession.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButtonOuvrirSession.Visible = False
        '
        'GunaPanelFormTop
        '
        Me.GunaPanelFormTop.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaPanelFormTop.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GunaPanelFormTop.Controls.Add(Me.GunaLabelNomUtilisateur)
        Me.GunaPanelFormTop.Controls.Add(Me.GunaLabelUsername)
        Me.GunaTransitionAnimation.SetDecoration(Me.GunaPanelFormTop, Guna.UI.Animation.DecorationType.None)
        Me.GunaPanelFormTop.Location = New System.Drawing.Point(-2, 1)
        Me.GunaPanelFormTop.Name = "GunaPanelFormTop"
        Me.GunaPanelFormTop.Size = New System.Drawing.Size(467, 31)
        Me.GunaPanelFormTop.TabIndex = 5
        '
        'GunaLabelNomUtilisateur
        '
        Me.GunaLabelNomUtilisateur.AutoSize = True
        Me.GunaTransitionAnimation.SetDecoration(Me.GunaLabelNomUtilisateur, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabelNomUtilisateur.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabelNomUtilisateur.ForeColor = System.Drawing.Color.White
        Me.GunaLabelNomUtilisateur.Location = New System.Drawing.Point(188, 8)
        Me.GunaLabelNomUtilisateur.Name = "GunaLabelNomUtilisateur"
        Me.GunaLabelNomUtilisateur.Size = New System.Drawing.Size(134, 16)
        Me.GunaLabelNomUtilisateur.TabIndex = 10
        Me.GunaLabelNomUtilisateur.Text = "ADMINISTRATION"
        Me.GunaLabelNomUtilisateur.Visible = False
        '
        'GunaLabelUsername
        '
        Me.GunaLabelUsername.AutoSize = True
        Me.GunaTransitionAnimation.SetDecoration(Me.GunaLabelUsername, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabelUsername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabelUsername.ForeColor = System.Drawing.Color.White
        Me.GunaLabelUsername.Location = New System.Drawing.Point(264, 8)
        Me.GunaLabelUsername.Name = "GunaLabelUsername"
        Me.GunaLabelUsername.Size = New System.Drawing.Size(0, 17)
        Me.GunaLabelUsername.TabIndex = 8
        '
        'GunaCheckBoxVersion
        '
        Me.GunaCheckBoxVersion.BaseColor = System.Drawing.Color.White
        Me.GunaCheckBoxVersion.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBoxVersion.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTransitionAnimation.SetDecoration(Me.GunaCheckBoxVersion, Guna.UI.Animation.DecorationType.None)
        Me.GunaCheckBoxVersion.FillColor = System.Drawing.Color.White
        Me.GunaCheckBoxVersion.Location = New System.Drawing.Point(321, 161)
        Me.GunaCheckBoxVersion.Name = "GunaCheckBoxVersion"
        Me.GunaCheckBoxVersion.Size = New System.Drawing.Size(20, 20)
        Me.GunaCheckBoxVersion.TabIndex = 6
        '
        'GunaLineTextBoxUsername
        '
        Me.GunaLineTextBoxUsername.BackColor = System.Drawing.Color.White
        Me.GunaLineTextBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTransitionAnimation.SetDecoration(Me.GunaLineTextBoxUsername, Guna.UI.Animation.DecorationType.None)
        Me.GunaLineTextBoxUsername.FocusedLineColor = System.Drawing.Color.White
        Me.GunaLineTextBoxUsername.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLineTextBoxUsername.ForeColor = System.Drawing.Color.Black
        Me.GunaLineTextBoxUsername.LineColor = System.Drawing.Color.Black
        Me.GunaLineTextBoxUsername.LineSize = 2
        Me.GunaLineTextBoxUsername.Location = New System.Drawing.Point(118, 37)
        Me.GunaLineTextBoxUsername.Name = "GunaLineTextBoxUsername"
        Me.GunaLineTextBoxUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBoxUsername.SelectedText = ""
        Me.GunaLineTextBoxUsername.Size = New System.Drawing.Size(262, 34)
        Me.GunaLineTextBoxUsername.TabIndex = 0
        '
        'GunaComboBoxVersion
        '
        Me.GunaComboBoxVersion.BackColor = System.Drawing.Color.Transparent
        Me.GunaComboBoxVersion.BaseColor = System.Drawing.Color.White
        Me.GunaComboBoxVersion.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaComboBoxVersion.BorderSize = 1
        Me.GunaTransitionAnimation.SetDecoration(Me.GunaComboBoxVersion, Guna.UI.Animation.DecorationType.None)
        Me.GunaComboBoxVersion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GunaComboBoxVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GunaComboBoxVersion.FocusedColor = System.Drawing.Color.Empty
        Me.GunaComboBoxVersion.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaComboBoxVersion.ForeColor = System.Drawing.Color.Black
        Me.GunaComboBoxVersion.FormattingEnabled = True
        Me.GunaComboBoxVersion.ItemHeight = 25
        Me.GunaComboBoxVersion.Location = New System.Drawing.Point(118, 120)
        Me.GunaComboBoxVersion.Name = "GunaComboBoxVersion"
        Me.GunaComboBoxVersion.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaComboBoxVersion.OnHoverItemForeColor = System.Drawing.Color.White
        Me.GunaComboBoxVersion.Size = New System.Drawing.Size(262, 31)
        Me.GunaComboBoxVersion.TabIndex = 2
        Me.GunaComboBoxVersion.Visible = False
        '
        'GunaButtonAnnulerAccueil
        '
        Me.GunaButtonAnnulerAccueil.AnimationHoverSpeed = 0.07!
        Me.GunaButtonAnnulerAccueil.AnimationSpeed = 0.03!
        Me.GunaButtonAnnulerAccueil.BackColor = System.Drawing.Color.Transparent
        Me.GunaButtonAnnulerAccueil.BaseColor = System.Drawing.Color.White
        Me.GunaButtonAnnulerAccueil.BorderColor = System.Drawing.Color.Black
        Me.GunaTransitionAnimation.SetDecoration(Me.GunaButtonAnnulerAccueil, Guna.UI.Animation.DecorationType.None)
        Me.GunaButtonAnnulerAccueil.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButtonAnnulerAccueil.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButtonAnnulerAccueil.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButtonAnnulerAccueil.ForeColor = System.Drawing.Color.Black
        Me.GunaButtonAnnulerAccueil.Image = Nothing
        Me.GunaButtonAnnulerAccueil.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonAnnulerAccueil.Location = New System.Drawing.Point(9, 172)
        Me.GunaButtonAnnulerAccueil.Name = "GunaButtonAnnulerAccueil"
        Me.GunaButtonAnnulerAccueil.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButtonAnnulerAccueil.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButtonAnnulerAccueil.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonAnnulerAccueil.OnHoverImage = Nothing
        Me.GunaButtonAnnulerAccueil.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonAnnulerAccueil.Radius = 4
        Me.GunaButtonAnnulerAccueil.Size = New System.Drawing.Size(138, 27)
        Me.GunaButtonAnnulerAccueil.TabIndex = 5
        Me.GunaButtonAnnulerAccueil.Text = "Annuler"
        Me.GunaButtonAnnulerAccueil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButtonAnnulerAccueil.Visible = False
        '
        'GunaLabelVersion
        '
        Me.GunaLabelVersion.AutoSize = True
        Me.GunaTransitionAnimation.SetDecoration(Me.GunaLabelVersion, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabelVersion.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabelVersion.ForeColor = System.Drawing.Color.Black
        Me.GunaLabelVersion.Location = New System.Drawing.Point(46, 125)
        Me.GunaLabelVersion.Name = "GunaLabelVersion"
        Me.GunaLabelVersion.Size = New System.Drawing.Size(58, 16)
        Me.GunaLabelVersion.TabIndex = 5
        Me.GunaLabelVersion.Text = "Version :"
        Me.GunaLabelVersion.Visible = False
        '
        'GunaLineTextBoxMotDePasse
        '
        Me.GunaLineTextBoxMotDePasse.BackColor = System.Drawing.Color.White
        Me.GunaLineTextBoxMotDePasse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTransitionAnimation.SetDecoration(Me.GunaLineTextBoxMotDePasse, Guna.UI.Animation.DecorationType.None)
        Me.GunaLineTextBoxMotDePasse.FocusedLineColor = System.Drawing.Color.White
        Me.GunaLineTextBoxMotDePasse.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLineTextBoxMotDePasse.ForeColor = System.Drawing.Color.Black
        Me.GunaLineTextBoxMotDePasse.LineColor = System.Drawing.Color.Black
        Me.GunaLineTextBoxMotDePasse.LineSize = 2
        Me.GunaLineTextBoxMotDePasse.Location = New System.Drawing.Point(119, 77)
        Me.GunaLineTextBoxMotDePasse.Name = "GunaLineTextBoxMotDePasse"
        Me.GunaLineTextBoxMotDePasse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.GunaLineTextBoxMotDePasse.SelectedText = ""
        Me.GunaLineTextBoxMotDePasse.Size = New System.Drawing.Size(262, 34)
        Me.GunaLineTextBoxMotDePasse.TabIndex = 1
        Me.GunaLineTextBoxMotDePasse.UseSystemPasswordChar = True
        '
        'GunaLabelPwd
        '
        Me.GunaLabelPwd.AutoSize = True
        Me.GunaTransitionAnimation.SetDecoration(Me.GunaLabelPwd, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabelPwd.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabelPwd.ForeColor = System.Drawing.Color.Black
        Me.GunaLabelPwd.Location = New System.Drawing.Point(5, 80)
        Me.GunaLabelPwd.Name = "GunaLabelPwd"
        Me.GunaLabelPwd.Size = New System.Drawing.Size(109, 20)
        Me.GunaLabelPwd.TabIndex = 5
        Me.GunaLabelPwd.Text = "Mot de passe : "
        Me.GunaLabelPwd.Visible = False
        '
        'GunaLabelUser
        '
        Me.GunaLabelUser.AutoSize = True
        Me.GunaTransitionAnimation.SetDecoration(Me.GunaLabelUser, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabelUser.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabelUser.ForeColor = System.Drawing.Color.Black
        Me.GunaLabelUser.Location = New System.Drawing.Point(27, 38)
        Me.GunaLabelUser.Name = "GunaLabelUser"
        Me.GunaLabelUser.Size = New System.Drawing.Size(87, 20)
        Me.GunaLabelUser.TabIndex = 3
        Me.GunaLabelUser.Text = "Utilisateur : "
        Me.GunaLabelUser.Visible = False
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaTransitionAnimation.SetDecoration(Me.GunaLabel6, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel6.ForeColor = System.Drawing.Color.White
        Me.GunaLabel6.Location = New System.Drawing.Point(148, 311)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(13, 15)
        Me.GunaLabel6.TabIndex = 1
        Me.GunaLabel6.Text = "a"
        '
        'GunaTransitionAnimation
        '
        Me.GunaTransitionAnimation.AnimationType = Guna.UI.Animation.AnimationType.Scale
        Me.GunaTransitionAnimation.Cursor = Nothing
        Animation4.AnimateOnlyDifferences = True
        Animation4.BlindCoeff = CType(resources.GetObject("Animation4.BlindCoeff"), System.Drawing.PointF)
        Animation4.LeafCoeff = 0!
        Animation4.MaxTime = 1.0!
        Animation4.MinTime = 0!
        Animation4.MosaicCoeff = CType(resources.GetObject("Animation4.MosaicCoeff"), System.Drawing.PointF)
        Animation4.MosaicShift = CType(resources.GetObject("Animation4.MosaicShift"), System.Drawing.PointF)
        Animation4.MosaicSize = 0
        Animation4.Padding = New System.Windows.Forms.Padding(0)
        Animation4.RotateCoeff = 0!
        Animation4.RotateLimit = 0!
        Animation4.ScaleCoeff = CType(resources.GetObject("Animation4.ScaleCoeff"), System.Drawing.PointF)
        Animation4.SlideCoeff = CType(resources.GetObject("Animation4.SlideCoeff"), System.Drawing.PointF)
        Animation4.TimeCoeff = 0!
        Animation4.TransparencyCoeff = 0!
        Me.GunaTransitionAnimation.DefaultAnimation = Animation4
        Me.GunaTransitionAnimation.MaxAnimationTime = 1000
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.BorderSize = 2
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel1)
        Me.GunaGroupBox1.Controls.Add(Me.PictureBox1)
        Me.GunaGroupBox1.Controls.Add(Me.Label1)
        Me.GunaGroupBox1.Controls.Add(Me.TextBox3)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLabel8)
        Me.GunaTransitionAnimation.SetDecoration(Me.GunaGroupBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaGroupBox1.LineBottom = 2
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.DeepSkyBlue
        Me.GunaGroupBox1.LineLeft = 2
        Me.GunaGroupBox1.LineRight = 2
        Me.GunaGroupBox1.LineTop = 2
        Me.GunaGroupBox1.Location = New System.Drawing.Point(1, 3)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Radius = 4
        Me.GunaGroupBox1.Size = New System.Drawing.Size(449, 210)
        Me.GunaGroupBox1.TabIndex = 6
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaTransitionAnimation.SetDecoration(Me.GunaLabel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel1.Font = New System.Drawing.Font("Maiandra GD", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(109, 181)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(224, 32)
        Me.GunaLabel1.TabIndex = 10
        Me.GunaLabel1.Text = "TECHFLECTION"
        '
        'PictureBox1
        '
        Me.GunaTransitionAnimation.SetDecoration(Me.PictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-40, -84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(541, 477)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.GunaTransitionAnimation.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Impact", 120.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 195)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LYTE"
        Me.Label1.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaTransitionAnimation.SetDecoration(Me.TextBox3, Guna.UI.Animation.DecorationType.None)
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.Black
        Me.TextBox3.Location = New System.Drawing.Point(3, 181)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(459, 22)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.Text = "V.1.0.1"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox3.Visible = False
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaTransitionAnimation.SetDecoration(Me.GunaLabel8, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel8.Location = New System.Drawing.Point(74, 153)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(312, 20)
        Me.GunaLabel8.TabIndex = 1
        Me.GunaLabel8.Text = "LOGICIEL DE GESTION HÔTELIERE"
        Me.GunaLabel8.Visible = False
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.GunaPanelFormTop
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'AccueilForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(462, 477)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.PanelConnexion)
        Me.GunaTransitionAnimation.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AccueilForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelConnexion.ResumeLayout(False)
        Me.PanelConnexion.PerformLayout()
        Me.GunaPanelFormTop.ResumeLayout(False)
        Me.GunaPanelFormTop.PerformLayout()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaTransitionAnimation As Guna.UI.WinForms.GunaTransition
    Friend WithEvents PanelConnexion As Panel
    Friend WithEvents GunaPanelFormTop As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabelUser As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLineTextBoxUsername As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLineTextBoxMotDePasse As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabelPwd As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaButtonOuvrirSession As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaLabelUsername As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabelNomUtilisateur As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaComboBoxVersion As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabelVersion As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaCheckBoxVersion As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaComboBoxLangue As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents TextBoxRights As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GunaButtonAnnulerAccueil As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButtonActivation As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
End Class
