Public Class undo
	Private Class node
		Public data As String
		Public pointer As node
	End Class
	Private Shared stack_pointer As node
	Shared Function push(item As String)
		'Check memory overflow
		Try
			'Push the item
			Dim new_node As New node
			new_node.data = item
			new_node.pointer = stack_pointer
			stack_pointer = new_node
			Return True
		Catch
			Return False
		End Try
	End Function
	Function pop()
		'Check stack underflow
		If Not IsNothing(stack_pointer) Then
			'Pop the item
			Dim popped As String = stack_pointer.data
			stack_pointer = stack_pointer.pointer
			Return popped

		Else
			Return Nothing
		End If
	End Function
End Class
