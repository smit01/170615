<Script Language="VB" runat="server">
   Dim weekstr() = { "��", "�@", "�G", "�T", "�|", "��", "��" }
   Dim Nweek = DatePart( DateInterval.Weekday, Now ) - 1
   Dim Cweek = weekstr(Nweek)
</Script>

<HTML><BODY BGCOLOR="#FFFFFF">
<H2>�P��<%=Cweek%>�����G�O
<HR WIDTH="100%"></H2>
<CENTER>
<IMG SRC="fruit<%=Nweek%>.gif">
</CENTER>
</BODY>
</HTML>
