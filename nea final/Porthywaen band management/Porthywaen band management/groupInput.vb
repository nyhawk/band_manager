Imports System.IO
Public Class groupInput
	'converts checkbox input into a string so can be displayed to user
	Shared Function groups(psb, pytb, pbb, starters)
		'validation
		If psb Then

			Dim writer As New StreamWriter("groupsTemp.csv")
		If psb = True Then
			writer.WriteLine("PSB", True)
		End If
		If pytb = True Then
			writer.WriteLine("PYTB", True)
		End If

		If pbb = True Then
			writer.WriteLine("PBB", True)
		End If

		If starters = True Then
			writer.WriteLine("Starters", True)
		End If
		writer.Close()

		Dim totalGroups As String
		Dim reader As New StreamReader("groupsTemp.csv")
		While reader.EndOfStream = False
			If totalGroups = "" Then
				totalGroups = reader.ReadLine
			Else
				totalGroups = totalGroups & ", " & reader.ReadLine
			End If
		End While

		reader.Close()
		My.Computer.FileSystem.DeleteFile("groupsTemp.csv")
		Return totalGroups
	End Function

	'converts stored groups string into boolean so can be shown in memberDetails form
	Shared Function tickPSB(data)
		Dim found As Boolean = False
		If data.contains("PSB") Then
			found = True
		End If
		Return found
	End Function
	Shared Function tickPYTB(data)
		Dim array As Array = data.split
		Dim found As Boolean = False
		Try
			For i = 0 To 6
				If array(i).contains("PYTB") Then
					found = True
				End If
			Next
		Catch ex As Exception
			MsgBox("PYTB conversion failed")
		End Try
		Return found
	End Function
	Shared Function tickPBB(data)
		Dim array As Array = data.split
		Dim found As Boolean = False
		Try
			For i = 0 To 6
				If array(i).contains("PBB") Then
					found = True
				End If
			Next
		Catch ex As Exception
			MsgBox("PYTB conversion failed")
		End Try
		Return found
	End Function
	Shared Function tickStarters(data)
		Dim array As Array = data.split
		Dim found As Boolean = False
		Try
			For i = 0 To 6
				If array(i).contains("Starters") Then
					found = True
				End If
			Next
		Catch ex As Exception
			MsgBox("PYTB conversion failed")
		End Try
		Return found
	End Function
	Shared Sub checkboxes(Optional photoPerm = "", Optional psb = "", Optional pytb = "", Optional pbb = "",
						  Optional starters = "")
		'sets the text on the checkboxes as it can disappear
		If photoPerm <> "" Then
			photoPerm = "Photograph permission"
		End If
		If psb <> "" Then
			psb = "PSB"
		End If
		If pytb <> "" Then
			pytb = "PYTB"
		End If
		If pbb <> "" Then
			pbb = "PBB"
		End If
		If starters <> "" Then
			starters = "Starters"
		End If
	End Sub
End Class
