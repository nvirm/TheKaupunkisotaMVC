Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function ScoresLoad() As ActionResult
        Return PartialView("_Scores", New ksBotSQL2Entities().Scoreboard)
    End Function
    Function TeamsLoad() As ActionResult
        Return PartialView("_Team", New ksBotSQL2Entities().Team)
    End Function
    Function MatchesLoad() As ActionResult
        Return PartialView("_Match", New ksBotSQL2Entities().Match)
    End Function

End Class
