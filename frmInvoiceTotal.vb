Public Class frmInvoiceTotal

    Private Sub btnCalculate_Click(sender As Object,
            e As EventArgs) Handles btnCalculate.Click

        Dim subtotal As Decimal = CDec(txtSubtotal.Text)
        Dim discountPercent As Decimal

        'If txtCustomerType.Text = "R" Or txtCustomerType.Text = "r" Then
        '    If subtotal < 100 Then
        '        discountPercent = 0D
        '    ElseIf subtotal >= 100 AndAlso subtotal < 250 Then
        '        discountPercent = 0.1D
        '    ElseIf subtotal >= 250 And subtotal < 500 Then
        '        discountPercent = 0.25D
        '    ElseIf subtotal >= 500 Then
        '        discountPercent = 0.3D
        '    End If
        'ElseIf txtCustomerType.Text = "C" Or txtCustomerType.Text = "c" Then
        '    discountPercent = 0.2D
        'ElseIf txtCustomerType.Text = "T" Or txtCustomerType.Text = "t" Then
        '    If subtotal < 500 Then
        '        discountPercent = 0.4D
        '    ElseIf subtotal >= 500 Then
        '        discountPercent = 0.5D
        '    End If
        'Else
        '    discountPercent = 0.1D
        'End If

        Select Case txtCustomerType.Text
            Case "R", "r"
                If subtotal < 100 Then
                    discountPercent = 0D
                ElseIf subtotal >= 100 AndAlso subtotal < 250 Then
                    discountPercent = 0.1D
                ElseIf subtotal >= 250 And subtotal < 500 Then
                    discountPercent = 0.25D
                ElseIf subtotal >= 500 Then
                    discountPercent = 0.3D
                End If
            Case "C", "c"
                discountPercent = 0.2D
            Case "T", "t"
                If subtotal < 500 Then
                    discountPercent = 0.4D
                ElseIf subtotal >= 500 Then
                    discountPercent = 0.5D
                End If
            Case Else
                discountPercent = 0.1D
        End Select

        Dim discountAmount As Decimal = subtotal * discountPercent
        Dim invoiceTotal As Decimal = subtotal - discountAmount

        txtDiscountPercent.Text = FormatPercent(discountPercent, 1)
        txtDiscountAmount.Text = FormatCurrency(discountAmount)
        txtTotal.Text = FormatCurrency(invoiceTotal)

        txtCustomerType.Select()

    End Sub

    Private Sub btnExit_Click(sender As Object,
            e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class