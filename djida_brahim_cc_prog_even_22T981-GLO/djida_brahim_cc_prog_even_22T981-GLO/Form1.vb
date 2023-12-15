' Import des espaces de noms nécessaires
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Public Class Form1


    ' Création d'une liste de médicaments
    Dim medicaments As New List(Of String)

    ' Méthode pour rafraîchir la liste des médicaments affichée dans l'IHM
    Private Sub RefreshMedicamentsList()
        ListBoxMedicaments.Items.Clear()
        For Each medicament As String In medicaments
                ListBoxMedicaments.Items.Add(medicament)
            Next
        End Sub

        ' Ajouter un médicament
        Private Sub ButtonAjouter_Click(sender As Object, e As EventArgs) Handles ButtonAjouter.Click
            Dim nomMedicament As String = TextBoxNomMedicament.Text
            ' Vérifier si le médicament existe déjà
            If Not medicaments.Contains(nomMedicament) Then
                medicaments.Add(nomMedicament)
                RefreshMedicamentsList()
                TextBoxNomMedicament.Clear()
            Else
                MessageBox.Show("Ce médicament existe déjà.", "Erreur d'ajout")
            End If
        End Sub

        ' Supprimer un médicament
        Private Sub ButtonSupprimer_Click(sender As Object, e As EventArgs) Handles ButtonSupprimer.Click
            If ListBoxMedicaments.SelectedIndex <> -1 Then
                medicaments.RemoveAt(ListBoxMedicaments.SelectedIndex)
                RefreshMedicamentsList()
            Else
                MessageBox.Show("Sélectionnez un médicament à supprimer.", "Erreur de suppression")
            End If
        End Sub

        ' Modifier un médicament
        Private Sub ButtonModifier_Click(sender As Object, e As EventArgs) Handles ButtonModifier.Click
            If ListBoxMedicaments.SelectedIndex <> -1 Then
                Dim nouveauNom As String = InputBox("Entrez le nouveau nom pour le médicament sélectionné :")
                If Not String.IsNullOrEmpty(nouveauNom) Then
                    medicaments(ListBoxMedicaments.SelectedIndex) = nouveauNom
                    RefreshMedicamentsList()
                End If
            Else
                MessageBox.Show("Sélectionnez un médicament à modifier.", "Erreur de modification")
            End If
        End Sub


End Class
