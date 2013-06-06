Imports Oracle.DataAccess.Client
Imports AerOS.mdl_admin

Public Class frm_cliente
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        Try
            frm_main._cnn.Open()
            _INSERTAR_CLIENTE(txt_dpi.Text, txt_passaport.Text, txt_nacional.Text, txt_fe.Value.Date.ToString, txt_nombre.Text, txt_apellido.Text, txt_usuario.Text, txt_pass.Text)
            txt_dpi.Text = ""
            txt_apellido.Text = ""
            txt_nacional.Text = ""
            txt_nombre.Text = ""
            txt_pass.Text = ""
            txt_passaport.Text = ""
            txt_usuario.Text = ""
            MsgBox("Cliente Inscrito")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            frm_main._cnn.Close()
        End Try

    End Sub

   


  
    Private Sub frm_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class