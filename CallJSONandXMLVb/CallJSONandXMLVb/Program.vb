Imports System.Web.Script.Serialization

Module Program

    Sub Main()
        Dim xmlClient As JSONandXMLVb.JSONandXMLSoapClient = New JSONandXMLVb.JSONandXMLSoapClient
        Dim teamFromXML = xmlClient.GetTeamFromXML
        Console.WriteLine("XML'den gelen sonuçlar:")
        For Each item In teamFromXML
            Console.WriteLine(item.Id & " " & item.Name & " " & item.Position & " " & item.Salary)
        Next
        Console.WriteLine()

        Dim jsonClient As JSONandXMLVb.JSONandXMLSoapClient = New JSONandXMLVb.JSONandXMLSoapClient
        Dim teamFromJSON = jsonClient.GetTeamFromJSON
        Dim jss As JavaScriptSerializer = New JavaScriptSerializer
        Dim members As List(Of Member) = New List(Of Member)
        members = jss.Deserialize(Of List(Of Member))(teamFromJSON)
        Console.WriteLine("JSON'dan gelen sonuçlar:")
        For Each item In members
            Console.WriteLine(item.Id & " " & item.Name & " " & item.Position & " " & item.Salary)
        Next
        Console.ReadKey()

    End Sub

End Module
