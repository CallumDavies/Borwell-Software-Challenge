Public Class Form1
    'Assumptions
    '1 litre of paint will cover approximately 16 square metres per coat.
    'The room is some form of quadrilateral - No curves in the room
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decVolume As Decimal
        Dim decFloorArea As Decimal
        Dim decPaint As Decimal
        Dim decWallArea As Decimal
        ' Dim decDoorWindows As Decimal

        If txtHeight.Text = "" Or txtLength.Text = "" Or txtWidth.Text = "" Or txtAreaOfDoors.Text = "" Or txtAreaOfWindows.Text = "" Or cmbCoats.Text = "" Then 'Data must be entered into all fields
            MessageBox.Show("Data must be entered into all available fields")
        ElseIf Not IsNumeric(txtHeight.Text) Or Not IsNumeric(txtLength.Text) Or Not IsNumeric(txtWidth.Text) Or Not IsNumeric(txtAreaOfDoors.Text) Or Not IsNumeric(txtAreaOfWindows.Text) Then
            MessageBox.Show("Input boxes must only contain numbers")
        Else

            decVolume = txtLength.Text * txtWidth.Text * txtHeight.Text 'multiplies length by width by height
            decFloorArea = txtLength.Text * txtWidth.Text 'multiplies length of room by its width
            'First calculates the area of all 4 walls, then subtracts the area covered by windows or doors
            decWallArea = ((txtWidth.Text * txtHeight.Text) * 2) + ((txtLength.Text * txtHeight.Text) * 2)
            decWallArea = decWallArea - (txtAreaOfDoors.Text + txtAreaOfWindows.Text)

            decPaint = (decWallArea / 16) * cmbCoats.Text


            txtFloor.Text = decFloorArea
            txtVol.Text = decVolume
            txtPaint.Text = Format((decPaint), "0.00L")
        End If
    End Sub

End Class
