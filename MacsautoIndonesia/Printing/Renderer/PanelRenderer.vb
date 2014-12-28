Imports MacsautoIndonesia.Printing.Page.Content
Imports MacsautoIndonesia.Printing.Renderer.Contract

Namespace Printing.Renderer
    Public Class PanelRenderer
        Implements IRenderer(Of Panel)

        Private ReadOnly _panelGroups as New Dictionary(Of Panel, string)

        Public Function Render(ByVal page As Page.Page) As Panel Implements IRenderer(Of Panel).Render
            Dim panel As Panel = New Panel()
            Dim contentPanel As Panel = Render(page.Content)

            panel.Margin = page.Margin
            panel.Width = page.Width
            panel.Height = contentPanel.Height + page.Margin.Top + page.Margin.Bottom

            panel.Controls.Add(Render(page.Content))

            If Not page.Logo Is Nothing Then
                Dim pictureBox As New PictureBox

                pictureBox.Dock = DockStyle.Top
                pictureBox.Image = page.Logo
                pictureBox.Location = New Point(0, 0)
                pictureBox.Name = "LogoBox"
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom
                pictureBox.Size = New Size(page.Width / 2, (page.Logo.Height / (page.Logo.Width / page.Width)) / 2)
                pictureBox.Margin = New Padding(10)

                panel.Controls.Add(pictureBox)
            End If

            Return panel
        End Function

        Public Function Render(ByVal line As Line)
            Dim panel As Panel = New Panel

            panel.Dock = line.Dock
            panel.Height = 0
            panel.Name = line.Name

            If line.Sublines.Count = 0 And line.Text <> "" Then
                Dim label As Label = New Label

                label.Text = line.Text
                label.TextAlign = line.Alignment
                label.Font = line.Font
                label.AutoSize = False
                label.Dock = DockStyle.Top

                Dim textMeasurement As Size = TextRenderer.MeasureText(line.Text, line.Font)

                label.Width = textMeasurement.Width + 5
                'label.Height = (textMeasurement.Height * Math.Ceiling(textMeasurement.Width / panel.Width)) * 1.5
                label.Height = textMeasurement.Height * 1.5

                panel.Height = (panel.Height + label.Height + line.Margin.Top + line.Margin.Bottom)
                panel.Width = label.Width

                panel.Controls.Add(label)
                panel.Controls.SetChildIndex(label, 0)

                If Not String.IsNullOrEmpty(line.Group) Then
                    Dim mostWide As Panel = panel
                    
                    _panelGroups.Add(panel, line.Group)
                    
                    For Each lines As KeyValuePair(Of Panel, String) In _panelGroups
                        If lines.Value = line.Group And lines.Key.Width >= panel.Width Then
                            'mostWide = lines.Key
                        End If
                    Next

                    For Each lines As KeyValuePair(Of Panel, String) In _panelGroups
                        lines.Key.Width = mostWide.Width
                    Next
                Else 
                    panel.Width = label.Width
                End If
            Else
                For Each subLine As Line In line.Sublines
                    If subLine.Name = "TRANSACTION FOOTER CONTAINER" Then
                        subLine.Name = subLine.Name
                    End If

                    Dim subPanel As Panel = Render(subLine)
                    Dim dockStyles As DockStyle() = {DockStyle.Top, DockStyle.Bottom}

                    If (panel.Dock.IsIn(dockStyles) And subPanel.Dock.IsIn(dockStyles)) Or (panel.Controls.Count = 0) Then
                        panel.Height = (panel.Height + subPanel.Height + subLine.Margin.Top + subLine.Margin.Bottom)
                    End If

                    If panel.Controls.Count = 0 Then
                        panel.Width = 0
                    End If

                    panel.Width += subPanel.Width

                    panel.Controls.Add(subPanel)
                    panel.Controls.SetChildIndex(subPanel, 0)
                Next
            End If

            Return panel
        End Function
    End Class
End Namespace