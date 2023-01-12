Public Class display
	Public Shared Sub displayData(dgvName, filename)
		Dim index As Integer
		Dim oneMember As memberInfo

		dgvName.Rows.Clear()

		FileOpen(1, filename, OpenMode.Random,,, Len(oneMember))

		Dim totalRecords As Integer = LOF(1) / Len(oneMember)
		For index = 1 To totalRecords
			FileGet(1, oneMember)
			dgvName.Rows.Add(oneMember.id, oneMember.name, oneMember.instrument, oneMember.phone)
		Next
		FileClose(1)
	End Sub
	Public Shared Sub displayInstruments(dgvName, filename)
		Dim index As Integer
		Dim oneInstrument As instruments

		dgvName.Rows.Clear()

		FileOpen(1, filename, OpenMode.Random,,, Len(oneInstrument))

		Dim totalRecords As Integer = LOF(1) / Len(oneInstrument)
		For index = 1 To totalRecords
			FileGet(1, oneInstrument)
			dgvName.Rows.Add(oneInstrument.serialNumber, oneInstrument.name, oneInstrument.instrument,
							 oneInstrument.holderID, oneInstrument.holderName)
		Next
		FileClose(1)
	End Sub
End Class
