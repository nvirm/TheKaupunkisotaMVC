@ModelType IEnumerable(Of KS2WebMVC.Match)

<div class="container body-content">

    <div class="col-xs-12">
        <h2 class="owfont-big">Pelatut ottelut</h2>

        <table class="table table-bordered">
            <tr class="xtrafont3">
                <th>
                    Lohko
                </th>
                <th>
                    Koti
                </th>
                <th>
                    Vieras
                </th>
                <th>
                    Tulos @*Tieto kaivettava*@
                </th>
                <th class="hidden-xs">
                    Aloitettu
                </th>
                <th class="hidden-xs">
                    Päättynyt
                </th>
                <th class="hidden-xs">
                    Mapit
                </th>
            </tr>

            @For Each item In Model.Where(Function(i) i.started = True).OrderByDescending(Function(i) i.Team1_division).ThenByDescending(Function(i) i.modified).Take(20)
                @<tr class="xtrafont3">
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Team1_division)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.MatchTeams().Where(Function(m) m.Team_id = item.Team1_id).FirstOrDefault().Team.CityName) @*ID -> Teamname*@
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.MatchTeams().Where(Function(m) m.Team_id = item.Team2_id).FirstOrDefault().Team.CityName) @*ID -> Teamname*@
                    </td>
                    <td>
                        @If item.WinnerTeam_id IsNot Nothing Then
                            @Html.DisplayFor(Function(modelItem) item.MatchTeams().Where(Function(m) m.Team_id = item.WinnerTeam_id).FirstOrDefault().Team.CityName) @*Teamname, muutetaanko tulokseksi muodossa koti - vieras? (matchteams where id = matchid)*@
                        End If
                        @If Not IsNothing(item.MatchTeams().FirstOrDefault().TeamId1Points) Then
                            @<span>@Html.DisplayFor(Function(m) item.MatchTeams().FirstOrDefault().TeamId1Points) - @Html.DisplayFor(Function(m) item.MatchTeams().FirstOrDefault().TeamId2Points)</span>
                            End If
                    </td>
                    <td class="hidden-xs">
                        @If (item.started = True) Then
                            @<i class="fa fa-check"></i>
                        Else

                        End If
                    </td>
                    <td class="hidden-xs">
                        @If (item.closed = True) Then
                            @<i class="fa fa-check"></i>
                        Else

                        End If
                    </td>
                    <td>
                        @If (item.ObsDraftURL IsNot Nothing) Then
                            @<a href="@(item.ObsDraftURL)" target="_blank">Katso</a>
                        Else

                        End If
                    </td>
                </tr>
            Next

        </table>
    </div>

    <div Class="col-xs-12">
        <h2 Class="owfont-big">Sovitut ottelut</h2>

        <Table Class="table table-bordered">
            <tr Class="xtrafont3">
                <th>
                                        Lohko
                </th>
                <th>
                                        Koti
                </th>
                <th>
                                        Vieras
                </th>
                <th>
                                        Ajankohta
                </th>
            </tr>
            @For Each item In Model.Where(Function(i) i.started = False AndAlso i.projectedstarttime IsNot Nothing).OrderBy(Function(i) i.projectedstarttime).ThenByDescending(Function(i) i.Team1_division).ThenByDescending(Function(i) i.projectedstarttime)
                @<tr class="xtrafont3">
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Team1_division)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.MatchTeams().Where(Function(m) m.Team_id = item.Team1_id).FirstOrDefault().Team.CityName)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.MatchTeams().Where(Function(m) m.Team_id = item.Team2_id).FirstOrDefault().Team.CityName)
                    </td>
                    <td>
                   @Html.DisplayFor(Function(modelItem) item.projectedstarttime)
                    </td>
                </tr>
            Next

        </table>
    </div>
</div>

        