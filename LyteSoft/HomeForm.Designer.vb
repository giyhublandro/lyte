<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaImageButtonMinimized = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButtonClose = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaButtonAccueil = New Guna.UI.WinForms.GunaButton()
        Me.GunaButtonBarResturant = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton26 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton8 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButtonReservation = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton10 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton12 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButtonCompatbilite = New Guna.UI.WinForms.GunaButton()
        Me.GunaButtonReception = New Guna.UI.WinForms.GunaButton()
        Me.GunaButtonEconomat = New Guna.UI.WinForms.GunaButton()
        Me.GunaButtonServiceEtage = New Guna.UI.WinForms.GunaButton()
        Me.GunaDragControl2 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaDragControl3 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton32 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButtonCusine = New Guna.UI.WinForms.GunaButton()
        Me.GunaButtonTechnique = New Guna.UI.WinForms.GunaButton()
        Me.GunaButtonMenuEconomat = New Guna.UI.WinForms.GunaButton()
        Me.GunaButtonMenuComptabilite = New Guna.UI.WinForms.GunaButton()
        Me.GunaButtonMenuBarRestaurant = New Guna.UI.WinForms.GunaButton()
        Me.GunaButtonCuisine = New Guna.UI.WinForms.GunaButton()
        Me.GunaButtonMenuService = New Guna.UI.WinForms.GunaButton()
        Me.GunaButtonMenuTechnique = New Guna.UI.WinForms.GunaButton()
        Me.GunaButtonMenuReservation = New Guna.UI.WinForms.GunaButton()
        Me.GunaButtonMenuReception = New Guna.UI.WinForms.GunaButton()
        Me.GunaButtonAccueil1 = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 0
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaPanel3
        '
        Me.GunaPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GunaPanel3.Location = New System.Drawing.Point(-2, 738)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(1358, 11)
        Me.GunaPanel3.TabIndex = 103
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.GunaPanel1
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GunaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GunaPanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel1.Controls.Add(Me.GunaImageButtonMinimized)
        Me.GunaPanel1.Controls.Add(Me.GunaImageButtonClose)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1350, 25)
        Me.GunaPanel1.TabIndex = 1
        '
        'GunaLabel2
        '
        Me.GunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(535, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(278, 21)
        Me.GunaLabel2.TabIndex = 26
        Me.GunaLabel2.Text = "MODULES DE BARCLES HOTEL SOFT"
        '
        'GunaImageButtonMinimized
        '
        Me.GunaImageButtonMinimized.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GunaImageButtonMinimized.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButtonMinimized.Image = CType(resources.GetObject("GunaImageButtonMinimized.Image"), System.Drawing.Image)
        Me.GunaImageButtonMinimized.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaImageButtonMinimized.Location = New System.Drawing.Point(1294, 1)
        Me.GunaImageButtonMinimized.Name = "GunaImageButtonMinimized"
        Me.GunaImageButtonMinimized.OnHoverImage = Nothing
        Me.GunaImageButtonMinimized.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButtonMinimized.Size = New System.Drawing.Size(27, 21)
        Me.GunaImageButtonMinimized.TabIndex = 3
        '
        'GunaImageButtonClose
        '
        Me.GunaImageButtonClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GunaImageButtonClose.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButtonClose.Image = CType(resources.GetObject("GunaImageButtonClose.Image"), System.Drawing.Image)
        Me.GunaImageButtonClose.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaImageButtonClose.Location = New System.Drawing.Point(1318, 1)
        Me.GunaImageButtonClose.Name = "GunaImageButtonClose"
        Me.GunaImageButtonClose.OnHoverImage = Nothing
        Me.GunaImageButtonClose.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButtonClose.Size = New System.Drawing.Size(27, 21)
        Me.GunaImageButtonClose.TabIndex = 2
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(2515, -3)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(24, 25)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "X"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(-1, 18)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(1352, 714)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 285
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaButtonAccueil
        '
        Me.GunaButtonAccueil.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaButtonAccueil.AnimationHoverSpeed = 0.07!
        Me.GunaButtonAccueil.AnimationSpeed = 0.03!
        Me.GunaButtonAccueil.BackColor = System.Drawing.Color.Transparent
        Me.GunaButtonAccueil.BaseColor = System.Drawing.SystemColors.Highlight
        Me.GunaButtonAccueil.BorderColor = System.Drawing.Color.Black
        Me.GunaButtonAccueil.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButtonAccueil.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButtonAccueil.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButtonAccueil.ForeColor = System.Drawing.Color.White
        Me.GunaButtonAccueil.Image = Nothing
        Me.GunaButtonAccueil.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonAccueil.Location = New System.Drawing.Point(172, 25)
        Me.GunaButtonAccueil.Name = "GunaButtonAccueil"
        Me.GunaButtonAccueil.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButtonAccueil.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButtonAccueil.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonAccueil.OnHoverImage = Nothing
        Me.GunaButtonAccueil.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonAccueil.Size = New System.Drawing.Size(84, 25)
        Me.GunaButtonAccueil.TabIndex = 259
        Me.GunaButtonAccueil.Text = "ACCUEIL"
        Me.GunaButtonAccueil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButtonAccueil.Visible = False
        '
        'GunaButtonBarResturant
        '
        Me.GunaButtonBarResturant.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GunaButtonBarResturant.AnimationHoverSpeed = 0.07!
        Me.GunaButtonBarResturant.AnimationSpeed = 0.03!
        Me.GunaButtonBarResturant.BaseColor = System.Drawing.Color.White
        Me.GunaButtonBarResturant.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.GunaButtonBarResturant.BorderSize = 1
        Me.GunaButtonBarResturant.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButtonBarResturant.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButtonBarResturant.Font = New System.Drawing.Font("Maiandra GD", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButtonBarResturant.ForeColor = System.Drawing.Color.Black
        Me.GunaButtonBarResturant.Image = CType(resources.GetObject("GunaButtonBarResturant.Image"), System.Drawing.Image)
        Me.GunaButtonBarResturant.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonBarResturant.Location = New System.Drawing.Point(21, 285)
        Me.GunaButtonBarResturant.Name = "GunaButtonBarResturant"
        Me.GunaButtonBarResturant.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButtonBarResturant.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButtonBarResturant.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonBarResturant.OnHoverImage = Nothing
        Me.GunaButtonBarResturant.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonBarResturant.Size = New System.Drawing.Size(313, 46)
        Me.GunaButtonBarResturant.TabIndex = 247
        Me.GunaButtonBarResturant.Text = "BAR / RESTAURANT"
        Me.GunaButtonBarResturant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton26
        '
        Me.GunaButton26.AnimationHoverSpeed = 0.07!
        Me.GunaButton26.AnimationSpeed = 0.03!
        Me.GunaButton26.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton26.BaseColor = System.Drawing.Color.Crimson
        Me.GunaButton26.BorderColor = System.Drawing.Color.Black
        Me.GunaButton26.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton26.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton26.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton26.ForeColor = System.Drawing.Color.White
        Me.GunaButton26.Image = Nothing
        Me.GunaButton26.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton26.Location = New System.Drawing.Point(43, 550)
        Me.GunaButton26.Name = "GunaButton26"
        Me.GunaButton26.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton26.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton26.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton26.OnHoverImage = Nothing
        Me.GunaButton26.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton26.Size = New System.Drawing.Size(277, 25)
        Me.GunaButton26.TabIndex = 250
        Me.GunaButton26.Visible = False
        '
        'GunaButton8
        '
        Me.GunaButton8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GunaButton8.AnimationHoverSpeed = 0.07!
        Me.GunaButton8.AnimationSpeed = 0.03!
        Me.GunaButton8.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton8.BaseColor = System.Drawing.SystemColors.MenuHighlight
        Me.GunaButton8.BorderColor = System.Drawing.Color.Black
        Me.GunaButton8.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton8.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton8.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton8.ForeColor = System.Drawing.Color.White
        Me.GunaButton8.Image = Nothing
        Me.GunaButton8.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton8.Location = New System.Drawing.Point(43, 232)
        Me.GunaButton8.Name = "GunaButton8"
        Me.GunaButton8.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton8.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton8.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton8.OnHoverImage = Nothing
        Me.GunaButton8.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton8.Size = New System.Drawing.Size(277, 25)
        Me.GunaButton8.TabIndex = 254
        Me.GunaButton8.Visible = False
        '
        'GunaButtonReservation
        '
        Me.GunaButtonReservation.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GunaButtonReservation.AnimationHoverSpeed = 0.07!
        Me.GunaButtonReservation.AnimationSpeed = 0.03!
        Me.GunaButtonReservation.BaseColor = System.Drawing.SystemColors.MenuHighlight
        Me.GunaButtonReservation.BorderColor = System.Drawing.Color.Black
        Me.GunaButtonReservation.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButtonReservation.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButtonReservation.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButtonReservation.ForeColor = System.Drawing.Color.White
        Me.GunaButtonReservation.Image = CType(resources.GetObject("GunaButtonReservation.Image"), System.Drawing.Image)
        Me.GunaButtonReservation.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonReservation.Location = New System.Drawing.Point(21, 99)
        Me.GunaButtonReservation.Name = "GunaButtonReservation"
        Me.GunaButtonReservation.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButtonReservation.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButtonReservation.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonReservation.OnHoverImage = Nothing
        Me.GunaButtonReservation.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonReservation.Size = New System.Drawing.Size(313, 46)
        Me.GunaButtonReservation.TabIndex = 252
        Me.GunaButtonReservation.Text = "RESERVATION"
        Me.GunaButtonReservation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButtonReservation.Visible = False
        '
        'GunaButton10
        '
        Me.GunaButton10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GunaButton10.AnimationHoverSpeed = 0.07!
        Me.GunaButton10.AnimationSpeed = 0.03!
        Me.GunaButton10.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton10.BaseColor = System.Drawing.SystemColors.MenuHighlight
        Me.GunaButton10.BorderColor = System.Drawing.Color.Black
        Me.GunaButton10.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton10.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton10.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton10.ForeColor = System.Drawing.Color.White
        Me.GunaButton10.Image = Nothing
        Me.GunaButton10.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton10.Location = New System.Drawing.Point(43, 294)
        Me.GunaButton10.Name = "GunaButton10"
        Me.GunaButton10.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton10.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton10.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton10.OnHoverImage = Nothing
        Me.GunaButton10.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton10.Size = New System.Drawing.Size(277, 25)
        Me.GunaButton10.TabIndex = 256
        Me.GunaButton10.Visible = False
        '
        'GunaButton12
        '
        Me.GunaButton12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GunaButton12.AnimationHoverSpeed = 0.07!
        Me.GunaButton12.AnimationSpeed = 0.03!
        Me.GunaButton12.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton12.BaseColor = System.Drawing.SystemColors.MenuHighlight
        Me.GunaButton12.BorderColor = System.Drawing.Color.Black
        Me.GunaButton12.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton12.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton12.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton12.ForeColor = System.Drawing.Color.White
        Me.GunaButton12.Image = Nothing
        Me.GunaButton12.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton12.Location = New System.Drawing.Point(43, 356)
        Me.GunaButton12.Name = "GunaButton12"
        Me.GunaButton12.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton12.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton12.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton12.OnHoverImage = Nothing
        Me.GunaButton12.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton12.Size = New System.Drawing.Size(277, 25)
        Me.GunaButton12.TabIndex = 258
        Me.GunaButton12.Visible = False
        '
        'GunaButtonCompatbilite
        '
        Me.GunaButtonCompatbilite.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaButtonCompatbilite.AnimationHoverSpeed = 0.07!
        Me.GunaButtonCompatbilite.AnimationSpeed = 0.03!
        Me.GunaButtonCompatbilite.BaseColor = System.Drawing.Color.White
        Me.GunaButtonCompatbilite.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.GunaButtonCompatbilite.BorderSize = 1
        Me.GunaButtonCompatbilite.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButtonCompatbilite.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButtonCompatbilite.Font = New System.Drawing.Font("Maiandra GD", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButtonCompatbilite.ForeColor = System.Drawing.Color.Black
        Me.GunaButtonCompatbilite.Image = CType(resources.GetObject("GunaButtonCompatbilite.Image"), System.Drawing.Image)
        Me.GunaButtonCompatbilite.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonCompatbilite.Location = New System.Drawing.Point(21, 541)
        Me.GunaButtonCompatbilite.Name = "GunaButtonCompatbilite"
        Me.GunaButtonCompatbilite.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButtonCompatbilite.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButtonCompatbilite.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonCompatbilite.OnHoverImage = Nothing
        Me.GunaButtonCompatbilite.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonCompatbilite.Size = New System.Drawing.Size(313, 46)
        Me.GunaButtonCompatbilite.TabIndex = 260
        Me.GunaButtonCompatbilite.Text = "COMPTABILITE ET FINANCES"
        Me.GunaButtonCompatbilite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButtonReception
        '
        Me.GunaButtonReception.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GunaButtonReception.AnimationHoverSpeed = 0.07!
        Me.GunaButtonReception.AnimationSpeed = 0.03!
        Me.GunaButtonReception.BaseColor = System.Drawing.Color.White
        Me.GunaButtonReception.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.GunaButtonReception.BorderSize = 1
        Me.GunaButtonReception.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButtonReception.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButtonReception.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButtonReception.ForeColor = System.Drawing.Color.Black
        Me.GunaButtonReception.Image = CType(resources.GetObject("GunaButtonReception.Image"), System.Drawing.Image)
        Me.GunaButtonReception.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonReception.Location = New System.Drawing.Point(21, 161)
        Me.GunaButtonReception.Name = "GunaButtonReception"
        Me.GunaButtonReception.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButtonReception.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButtonReception.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonReception.OnHoverImage = Nothing
        Me.GunaButtonReception.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonReception.Size = New System.Drawing.Size(313, 46)
        Me.GunaButtonReception.TabIndex = 266
        Me.GunaButtonReception.Text = "RECEPTION"
        Me.GunaButtonReception.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButtonEconomat
        '
        Me.GunaButtonEconomat.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GunaButtonEconomat.AnimationHoverSpeed = 0.07!
        Me.GunaButtonEconomat.AnimationSpeed = 0.03!
        Me.GunaButtonEconomat.BaseColor = System.Drawing.Color.White
        Me.GunaButtonEconomat.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.GunaButtonEconomat.BorderSize = 1
        Me.GunaButtonEconomat.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButtonEconomat.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButtonEconomat.Font = New System.Drawing.Font("Maiandra GD", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButtonEconomat.ForeColor = System.Drawing.Color.Black
        Me.GunaButtonEconomat.Image = CType(resources.GetObject("GunaButtonEconomat.Image"), System.Drawing.Image)
        Me.GunaButtonEconomat.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonEconomat.Location = New System.Drawing.Point(21, 409)
        Me.GunaButtonEconomat.Name = "GunaButtonEconomat"
        Me.GunaButtonEconomat.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButtonEconomat.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButtonEconomat.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonEconomat.OnHoverImage = Nothing
        Me.GunaButtonEconomat.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonEconomat.Size = New System.Drawing.Size(313, 46)
        Me.GunaButtonEconomat.TabIndex = 274
        Me.GunaButtonEconomat.Text = "ECONOMAT"
        Me.GunaButtonEconomat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButtonServiceEtage
        '
        Me.GunaButtonServiceEtage.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GunaButtonServiceEtage.AnimationHoverSpeed = 0.07!
        Me.GunaButtonServiceEtage.AnimationSpeed = 0.03!
        Me.GunaButtonServiceEtage.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GunaButtonServiceEtage.BaseColor = System.Drawing.SystemColors.MenuHighlight
        Me.GunaButtonServiceEtage.BorderColor = System.Drawing.Color.Black
        Me.GunaButtonServiceEtage.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButtonServiceEtage.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButtonServiceEtage.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButtonServiceEtage.ForeColor = System.Drawing.Color.White
        Me.GunaButtonServiceEtage.Image = CType(resources.GetObject("GunaButtonServiceEtage.Image"), System.Drawing.Image)
        Me.GunaButtonServiceEtage.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonServiceEtage.Location = New System.Drawing.Point(21, 223)
        Me.GunaButtonServiceEtage.Name = "GunaButtonServiceEtage"
        Me.GunaButtonServiceEtage.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButtonServiceEtage.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButtonServiceEtage.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonServiceEtage.OnHoverImage = Nothing
        Me.GunaButtonServiceEtage.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonServiceEtage.Size = New System.Drawing.Size(313, 46)
        Me.GunaButtonServiceEtage.TabIndex = 280
        Me.GunaButtonServiceEtage.Text = "SERVICE D'ETAGE"
        Me.GunaButtonServiceEtage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaDragControl2
        '
        Me.GunaDragControl2.TargetControl = Nothing
        '
        'GunaDragControl3
        '
        Me.GunaDragControl3.TargetControl = Me.GunaPanel1
        '
        'GunaButton1
        '
        Me.GunaButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.OrangeRed
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(703, 612)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(277, 25)
        Me.GunaButton1.TabIndex = 264
        Me.GunaButton1.Visible = False
        '
        'GunaButton2
        '
        Me.GunaButton2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.OrangeRed
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(703, 643)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Size = New System.Drawing.Size(277, 25)
        Me.GunaButton2.TabIndex = 263
        Me.GunaButton2.Visible = False
        '
        'GunaButton3
        '
        Me.GunaButton3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaButton3.AnimationHoverSpeed = 0.07!
        Me.GunaButton3.AnimationSpeed = 0.03!
        Me.GunaButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton3.BaseColor = System.Drawing.Color.OrangeRed
        Me.GunaButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton3.ForeColor = System.Drawing.Color.White
        Me.GunaButton3.Image = Nothing
        Me.GunaButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton3.Location = New System.Drawing.Point(703, 581)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Size = New System.Drawing.Size(277, 25)
        Me.GunaButton3.TabIndex = 265
        Me.GunaButton3.Visible = False
        '
        'GunaButton32
        '
        Me.GunaButton32.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaButton32.AnimationHoverSpeed = 0.07!
        Me.GunaButton32.AnimationSpeed = 0.03!
        Me.GunaButton32.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton32.BaseColor = System.Drawing.Color.OrangeRed
        Me.GunaButton32.BorderColor = System.Drawing.Color.Black
        Me.GunaButton32.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton32.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton32.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton32.ForeColor = System.Drawing.Color.White
        Me.GunaButton32.Image = Nothing
        Me.GunaButton32.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton32.Location = New System.Drawing.Point(703, 550)
        Me.GunaButton32.Name = "GunaButton32"
        Me.GunaButton32.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton32.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton32.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton32.OnHoverImage = Nothing
        Me.GunaButton32.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton32.Size = New System.Drawing.Size(277, 25)
        Me.GunaButton32.TabIndex = 262
        Me.GunaButton32.Visible = False
        '
        'GunaButtonCusine
        '
        Me.GunaButtonCusine.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GunaButtonCusine.AnimationHoverSpeed = 0.07!
        Me.GunaButtonCusine.AnimationSpeed = 0.03!
        Me.GunaButtonCusine.BaseColor = System.Drawing.SystemColors.MenuHighlight
        Me.GunaButtonCusine.BorderColor = System.Drawing.Color.Black
        Me.GunaButtonCusine.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButtonCusine.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButtonCusine.Font = New System.Drawing.Font("Maiandra GD", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButtonCusine.ForeColor = System.Drawing.Color.White
        Me.GunaButtonCusine.Image = CType(resources.GetObject("GunaButtonCusine.Image"), System.Drawing.Image)
        Me.GunaButtonCusine.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonCusine.Location = New System.Drawing.Point(21, 347)
        Me.GunaButtonCusine.Name = "GunaButtonCusine"
        Me.GunaButtonCusine.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButtonCusine.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButtonCusine.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonCusine.OnHoverImage = Nothing
        Me.GunaButtonCusine.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonCusine.Size = New System.Drawing.Size(313, 46)
        Me.GunaButtonCusine.TabIndex = 260
        Me.GunaButtonCusine.Text = "CUISINE"
        Me.GunaButtonCusine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButtonTechnique
        '
        Me.GunaButtonTechnique.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GunaButtonTechnique.AnimationHoverSpeed = 0.07!
        Me.GunaButtonTechnique.AnimationSpeed = 0.03!
        Me.GunaButtonTechnique.BaseColor = System.Drawing.SystemColors.MenuHighlight
        Me.GunaButtonTechnique.BorderColor = System.Drawing.Color.Black
        Me.GunaButtonTechnique.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButtonTechnique.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButtonTechnique.Font = New System.Drawing.Font("Maiandra GD", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButtonTechnique.ForeColor = System.Drawing.Color.White
        Me.GunaButtonTechnique.Image = CType(resources.GetObject("GunaButtonTechnique.Image"), System.Drawing.Image)
        Me.GunaButtonTechnique.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonTechnique.Location = New System.Drawing.Point(21, 472)
        Me.GunaButtonTechnique.Name = "GunaButtonTechnique"
        Me.GunaButtonTechnique.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButtonTechnique.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButtonTechnique.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonTechnique.OnHoverImage = Nothing
        Me.GunaButtonTechnique.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonTechnique.Size = New System.Drawing.Size(313, 46)
        Me.GunaButtonTechnique.TabIndex = 266
        Me.GunaButtonTechnique.Text = "TECHNIQUE"
        Me.GunaButtonTechnique.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButtonMenuEconomat
        '
        Me.GunaButtonMenuEconomat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaButtonMenuEconomat.AnimationHoverSpeed = 0.07!
        Me.GunaButtonMenuEconomat.AnimationSpeed = 0.03!
        Me.GunaButtonMenuEconomat.BackColor = System.Drawing.Color.Transparent
        Me.GunaButtonMenuEconomat.BaseColor = System.Drawing.Color.White
        Me.GunaButtonMenuEconomat.BorderColor = System.Drawing.Color.Black
        Me.GunaButtonMenuEconomat.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButtonMenuEconomat.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButtonMenuEconomat.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButtonMenuEconomat.ForeColor = System.Drawing.Color.Black
        Me.GunaButtonMenuEconomat.Image = Nothing
        Me.GunaButtonMenuEconomat.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonMenuEconomat.Location = New System.Drawing.Point(1081, 25)
        Me.GunaButtonMenuEconomat.Name = "GunaButtonMenuEconomat"
        Me.GunaButtonMenuEconomat.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButtonMenuEconomat.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButtonMenuEconomat.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonMenuEconomat.OnHoverImage = Nothing
        Me.GunaButtonMenuEconomat.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonMenuEconomat.Radius = 5
        Me.GunaButtonMenuEconomat.Size = New System.Drawing.Size(99, 25)
        Me.GunaButtonMenuEconomat.TabIndex = 270
        Me.GunaButtonMenuEconomat.Text = "ECONOMAT"
        Me.GunaButtonMenuEconomat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButtonMenuEconomat.Visible = False
        '
        'GunaButtonMenuComptabilite
        '
        Me.GunaButtonMenuComptabilite.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaButtonMenuComptabilite.AnimationHoverSpeed = 0.07!
        Me.GunaButtonMenuComptabilite.AnimationSpeed = 0.03!
        Me.GunaButtonMenuComptabilite.BackColor = System.Drawing.Color.Transparent
        Me.GunaButtonMenuComptabilite.BaseColor = System.Drawing.Color.DeepSkyBlue
        Me.GunaButtonMenuComptabilite.BorderColor = System.Drawing.Color.Black
        Me.GunaButtonMenuComptabilite.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButtonMenuComptabilite.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButtonMenuComptabilite.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButtonMenuComptabilite.ForeColor = System.Drawing.Color.White
        Me.GunaButtonMenuComptabilite.Image = Nothing
        Me.GunaButtonMenuComptabilite.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonMenuComptabilite.Location = New System.Drawing.Point(973, 25)
        Me.GunaButtonMenuComptabilite.Name = "GunaButtonMenuComptabilite"
        Me.GunaButtonMenuComptabilite.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButtonMenuComptabilite.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButtonMenuComptabilite.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonMenuComptabilite.OnHoverImage = Nothing
        Me.GunaButtonMenuComptabilite.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonMenuComptabilite.Radius = 5
        Me.GunaButtonMenuComptabilite.Size = New System.Drawing.Size(103, 25)
        Me.GunaButtonMenuComptabilite.TabIndex = 259
        Me.GunaButtonMenuComptabilite.Text = "COMPTABILITE"
        Me.GunaButtonMenuComptabilite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButtonMenuComptabilite.Visible = False
        '
        'GunaButtonMenuBarRestaurant
        '
        Me.GunaButtonMenuBarRestaurant.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaButtonMenuBarRestaurant.AnimationHoverSpeed = 0.07!
        Me.GunaButtonMenuBarRestaurant.AnimationSpeed = 0.03!
        Me.GunaButtonMenuBarRestaurant.BackColor = System.Drawing.Color.Transparent
        Me.GunaButtonMenuBarRestaurant.BaseColor = System.Drawing.Color.White
        Me.GunaButtonMenuBarRestaurant.BorderColor = System.Drawing.Color.Black
        Me.GunaButtonMenuBarRestaurant.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButtonMenuBarRestaurant.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButtonMenuBarRestaurant.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButtonMenuBarRestaurant.ForeColor = System.Drawing.Color.Black
        Me.GunaButtonMenuBarRestaurant.Image = Nothing
        Me.GunaButtonMenuBarRestaurant.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonMenuBarRestaurant.Location = New System.Drawing.Point(829, 25)
        Me.GunaButtonMenuBarRestaurant.Name = "GunaButtonMenuBarRestaurant"
        Me.GunaButtonMenuBarRestaurant.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButtonMenuBarRestaurant.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButtonMenuBarRestaurant.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonMenuBarRestaurant.OnHoverImage = Nothing
        Me.GunaButtonMenuBarRestaurant.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonMenuBarRestaurant.Radius = 5
        Me.GunaButtonMenuBarRestaurant.Size = New System.Drawing.Size(137, 25)
        Me.GunaButtonMenuBarRestaurant.TabIndex = 270
        Me.GunaButtonMenuBarRestaurant.Text = "BAR / RESTAURANT"
        Me.GunaButtonMenuBarRestaurant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButtonMenuBarRestaurant.Visible = False
        '
        'GunaButtonCuisine
        '
        Me.GunaButtonCuisine.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaButtonCuisine.AnimationHoverSpeed = 0.07!
        Me.GunaButtonCuisine.AnimationSpeed = 0.03!
        Me.GunaButtonCuisine.BackColor = System.Drawing.Color.Transparent
        Me.GunaButtonCuisine.BaseColor = System.Drawing.Color.DeepSkyBlue
        Me.GunaButtonCuisine.BorderColor = System.Drawing.Color.Black
        Me.GunaButtonCuisine.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButtonCuisine.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButtonCuisine.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButtonCuisine.ForeColor = System.Drawing.Color.White
        Me.GunaButtonCuisine.Image = Nothing
        Me.GunaButtonCuisine.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonCuisine.Location = New System.Drawing.Point(726, 25)
        Me.GunaButtonCuisine.Name = "GunaButtonCuisine"
        Me.GunaButtonCuisine.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButtonCuisine.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButtonCuisine.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonCuisine.OnHoverImage = Nothing
        Me.GunaButtonCuisine.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonCuisine.Radius = 5
        Me.GunaButtonCuisine.Size = New System.Drawing.Size(97, 25)
        Me.GunaButtonCuisine.TabIndex = 270
        Me.GunaButtonCuisine.Text = "CUISINE"
        Me.GunaButtonCuisine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButtonCuisine.Visible = False
        '
        'GunaButtonMenuService
        '
        Me.GunaButtonMenuService.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaButtonMenuService.AnimationHoverSpeed = 0.07!
        Me.GunaButtonMenuService.AnimationSpeed = 0.03!
        Me.GunaButtonMenuService.BackColor = System.Drawing.Color.Transparent
        Me.GunaButtonMenuService.BaseColor = System.Drawing.Color.White
        Me.GunaButtonMenuService.BorderColor = System.Drawing.Color.Black
        Me.GunaButtonMenuService.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButtonMenuService.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButtonMenuService.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButtonMenuService.ForeColor = System.Drawing.Color.Black
        Me.GunaButtonMenuService.Image = Nothing
        Me.GunaButtonMenuService.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonMenuService.Location = New System.Drawing.Point(597, 25)
        Me.GunaButtonMenuService.Name = "GunaButtonMenuService"
        Me.GunaButtonMenuService.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButtonMenuService.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButtonMenuService.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonMenuService.OnHoverImage = Nothing
        Me.GunaButtonMenuService.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonMenuService.Radius = 5
        Me.GunaButtonMenuService.Size = New System.Drawing.Size(123, 25)
        Me.GunaButtonMenuService.TabIndex = 259
        Me.GunaButtonMenuService.Text = "SERVICE D'ETAGE"
        Me.GunaButtonMenuService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButtonMenuService.Visible = False
        '
        'GunaButtonMenuTechnique
        '
        Me.GunaButtonMenuTechnique.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaButtonMenuTechnique.AnimationHoverSpeed = 0.07!
        Me.GunaButtonMenuTechnique.AnimationSpeed = 0.03!
        Me.GunaButtonMenuTechnique.BackColor = System.Drawing.Color.Transparent
        Me.GunaButtonMenuTechnique.BaseColor = System.Drawing.Color.DeepSkyBlue
        Me.GunaButtonMenuTechnique.BorderColor = System.Drawing.Color.Black
        Me.GunaButtonMenuTechnique.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButtonMenuTechnique.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButtonMenuTechnique.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButtonMenuTechnique.ForeColor = System.Drawing.Color.White
        Me.GunaButtonMenuTechnique.Image = Nothing
        Me.GunaButtonMenuTechnique.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonMenuTechnique.Location = New System.Drawing.Point(488, 25)
        Me.GunaButtonMenuTechnique.Name = "GunaButtonMenuTechnique"
        Me.GunaButtonMenuTechnique.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButtonMenuTechnique.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButtonMenuTechnique.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonMenuTechnique.OnHoverImage = Nothing
        Me.GunaButtonMenuTechnique.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonMenuTechnique.Radius = 5
        Me.GunaButtonMenuTechnique.Size = New System.Drawing.Size(100, 25)
        Me.GunaButtonMenuTechnique.TabIndex = 259
        Me.GunaButtonMenuTechnique.Text = "TECHNIQUE"
        Me.GunaButtonMenuTechnique.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButtonMenuTechnique.Visible = False
        '
        'GunaButtonMenuReservation
        '
        Me.GunaButtonMenuReservation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaButtonMenuReservation.AnimationHoverSpeed = 0.07!
        Me.GunaButtonMenuReservation.AnimationSpeed = 0.03!
        Me.GunaButtonMenuReservation.BackColor = System.Drawing.Color.Transparent
        Me.GunaButtonMenuReservation.BaseColor = System.Drawing.Color.White
        Me.GunaButtonMenuReservation.BorderColor = System.Drawing.Color.Black
        Me.GunaButtonMenuReservation.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButtonMenuReservation.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButtonMenuReservation.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButtonMenuReservation.ForeColor = System.Drawing.Color.Black
        Me.GunaButtonMenuReservation.Image = Nothing
        Me.GunaButtonMenuReservation.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonMenuReservation.Location = New System.Drawing.Point(376, 25)
        Me.GunaButtonMenuReservation.Name = "GunaButtonMenuReservation"
        Me.GunaButtonMenuReservation.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButtonMenuReservation.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButtonMenuReservation.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonMenuReservation.OnHoverImage = Nothing
        Me.GunaButtonMenuReservation.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonMenuReservation.Radius = 5
        Me.GunaButtonMenuReservation.Size = New System.Drawing.Size(107, 25)
        Me.GunaButtonMenuReservation.TabIndex = 259
        Me.GunaButtonMenuReservation.Text = "RESERVATION"
        Me.GunaButtonMenuReservation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButtonMenuReservation.Visible = False
        '
        'GunaButtonMenuReception
        '
        Me.GunaButtonMenuReception.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaButtonMenuReception.AnimationHoverSpeed = 0.07!
        Me.GunaButtonMenuReception.AnimationSpeed = 0.03!
        Me.GunaButtonMenuReception.BackColor = System.Drawing.Color.Transparent
        Me.GunaButtonMenuReception.BaseColor = System.Drawing.Color.DeepSkyBlue
        Me.GunaButtonMenuReception.BorderColor = System.Drawing.Color.Black
        Me.GunaButtonMenuReception.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButtonMenuReception.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButtonMenuReception.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButtonMenuReception.ForeColor = System.Drawing.Color.White
        Me.GunaButtonMenuReception.Image = Nothing
        Me.GunaButtonMenuReception.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonMenuReception.Location = New System.Drawing.Point(263, 25)
        Me.GunaButtonMenuReception.Name = "GunaButtonMenuReception"
        Me.GunaButtonMenuReception.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButtonMenuReception.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButtonMenuReception.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonMenuReception.OnHoverImage = Nothing
        Me.GunaButtonMenuReception.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonMenuReception.Radius = 5
        Me.GunaButtonMenuReception.Size = New System.Drawing.Size(107, 25)
        Me.GunaButtonMenuReception.TabIndex = 270
        Me.GunaButtonMenuReception.Text = "RECEPTION"
        Me.GunaButtonMenuReception.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButtonMenuReception.Visible = False
        '
        'GunaButtonAccueil1
        '
        Me.GunaButtonAccueil1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaButtonAccueil1.AnimationHoverSpeed = 0.07!
        Me.GunaButtonAccueil1.AnimationSpeed = 0.03!
        Me.GunaButtonAccueil1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButtonAccueil1.BaseColor = System.Drawing.Color.DarkGreen
        Me.GunaButtonAccueil1.BorderColor = System.Drawing.Color.Black
        Me.GunaButtonAccueil1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButtonAccueil1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButtonAccueil1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButtonAccueil1.ForeColor = System.Drawing.Color.White
        Me.GunaButtonAccueil1.Image = Nothing
        Me.GunaButtonAccueil1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButtonAccueil1.Location = New System.Drawing.Point(172, 24)
        Me.GunaButtonAccueil1.Name = "GunaButtonAccueil1"
        Me.GunaButtonAccueil1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButtonAccueil1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButtonAccueil1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButtonAccueil1.OnHoverImage = Nothing
        Me.GunaButtonAccueil1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButtonAccueil1.Size = New System.Drawing.Size(84, 26)
        Me.GunaButtonAccueil1.TabIndex = 286
        Me.GunaButtonAccueil1.Text = "ACCUEIL"
        Me.GunaButtonAccueil1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButtonAccueil1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 99.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(422, 528)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(809, 161)
        Me.Label1.TabIndex = 288
        Me.Label1.Text = "TECHFLECTION"
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 745)
        Me.ControlBox = False
        Me.Controls.Add(Me.GunaButtonEconomat)
        Me.Controls.Add(Me.GunaButtonTechnique)
        Me.Controls.Add(Me.GunaButtonCusine)
        Me.Controls.Add(Me.GunaButtonBarResturant)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GunaButtonAccueil1)
        Me.Controls.Add(Me.GunaButtonServiceEtage)
        Me.Controls.Add(Me.GunaButtonMenuEconomat)
        Me.Controls.Add(Me.GunaButtonCuisine)
        Me.Controls.Add(Me.GunaButtonMenuBarRestaurant)
        Me.Controls.Add(Me.GunaButtonMenuReception)
        Me.Controls.Add(Me.GunaButtonReception)
        Me.Controls.Add(Me.GunaButtonCompatbilite)
        Me.Controls.Add(Me.GunaButton32)
        Me.Controls.Add(Me.GunaButton3)
        Me.Controls.Add(Me.GunaButton2)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.GunaButtonMenuComptabilite)
        Me.Controls.Add(Me.GunaButtonMenuTechnique)
        Me.Controls.Add(Me.GunaButtonMenuService)
        Me.Controls.Add(Me.GunaButtonAccueil)
        Me.Controls.Add(Me.GunaButtonMenuReservation)
        Me.Controls.Add(Me.GunaButton12)
        Me.Controls.Add(Me.GunaPanel3)
        Me.Controls.Add(Me.GunaButton10)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.GunaButtonReservation)
        Me.Controls.Add(Me.GunaButton8)
        Me.Controls.Add(Me.GunaButton26)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HomeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HomeForm"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaButtonAccueil As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButtonServiceEtage As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButtonEconomat As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButtonReception As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButtonCompatbilite As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton12 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton10 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButtonReservation As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton8 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton26 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButtonBarResturant As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaDragControl2 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaDragControl3 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaButtonTechnique As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButtonCusine As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton32 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButtonAccueil1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButtonMenuEconomat As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButtonCuisine As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButtonMenuBarRestaurant As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButtonMenuReception As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButtonMenuComptabilite As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButtonMenuTechnique As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButtonMenuService As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButtonMenuReservation As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaImageButtonMinimized As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButtonClose As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
End Class
