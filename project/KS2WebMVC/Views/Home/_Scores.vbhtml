@ModelType IEnumerable(Of KS2WebMVC.Scoreboard)
<!--Table-->
<div class="container body-content">

    <!--COMP1-->
    <div class="col-xs-12">
        
        <h2 class="owfont-big">COMPETITIVE LOHKOT</h2>
        

        <h2 class="xtrafont2" style="text-align:left;">Lohko #1</h2>
        <table class="table table-bordered">
            <tr class="xtrafont3 hidden-xs">
                <th>
                    Kaupunki
                </th>
                <th>
                    Ottelut
                </th>
                <th>
                    W-D-L
                </th>
                <th class="hidden-xs">
                    RWon
                </th>
                <th class="hidden-xs">
                    RLose
                </th>
                <th>+-</th>
            </tr>
            <tr class="xtrafont3 visible-xs">
                <th>
                    Kaupunki
                </th>
                <th>
                    Ottelut
                </th>
                <th>
                    W-D-L
                </th>
                <th class="hidden-xs">
                    RWon
                </th>
                <th class="hidden-xs">
                    RLose
                </th>
                <th>+-</th>
            </tr>
            @For Each item In Model.Where(Function(i) i.Division.GetValueOrDefault = 1).OrderByDescending(Function(x) x.rndWins).ThenByDescending(Function(x) x.rndDraws).ThenBy(Function(x) x.rndLoses).ThenByDescending(Function(t) t.RndWon - t.RndLose)
                @<tr>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.CityName)
                    </td>
                     <td>
                         @Html.DisplayFor(Function(modelItem) item.GamesPlayed)
                     </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.rndWins) - @item.rndDraws - @item.rndLoses
                    </td>
                    <td class="hidden-xs">
                        @Html.DisplayFor(Function(modelItem) item.RndWon)
                    </td>
                    <td class="hidden-xs">
                        @Html.DisplayFor(Function(modelItem) item.RndLose)
                    </td>
                    @Code
                        Dim ns As Integer = 0
                        ns = (Int(item.RndWon) - Int(item.RndLose))
                        Dim ns1 As String = "x"
                        ns1 = ns.ToString("+#;-#;0")
                        @<td>@Html.Raw(ns1)</td>
                    End Code
                </tr>
                        Next

        </table>
    </div>

    <!--COMP2-->
    <div class="col-xs-12">
        <h2 class="xtrafont2" style="text-align:left;">Lohko #2</h2>
        <table class="table table-bordered">
            <tr class="xtrafont3 hidden-xs">
                <th>
                    Kaupunki
                </th>
                <th>
                    Ottelut
                </th>
                <th>
                    W-D-L
                </th>           
                <th class="hidden-xs">
                    RWon
                </th>
                <th class="hidden-xs">
                    RLose
                </th>
                <th>+-</th>
            </tr>
            <tr class="xtrafont3 visible-xs">
                <th>
                    Kaupunki
                </th>
                <th>
                    Ottelut
                </th>
                <th>
                    W-D-L
                </th>
                <th class="hidden-xs">
                    RWon
                </th>
                <th class="hidden-xs">
                    RLose
                </th>
                <th>+-</th>
            </tr>
            @For Each item In Model.Where(Function(i) i.Division.GetValueOrDefault = 2).OrderByDescending(Function(x) x.rndWins).ThenByDescending(Function(x) x.rndDraws).ThenBy(Function(x) x.rndLoses).ThenByDescending(Function(t) t.RndWon - t.RndLose)
                @<tr>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.CityName)
                    </td>
                     <td>
                         @Html.DisplayFor(Function(modelItem) item.GamesPlayed)
                     </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.rndWins) - @item.rndDraws - @item.rndLoses
                    </td>   
                    <td class="hidden-xs">
                        @Html.DisplayFor(Function(modelItem) item.RndWon)
                    </td>
                    <td class="hidden-xs">
                        @Html.DisplayFor(Function(modelItem) item.RndLose)
                    </td>
                    @Code
                        Dim ns As Integer = 0
                        ns = (Int(item.RndWon) - Int(item.RndLose))
                        Dim ns1 As String = "x"
                        ns1 = ns.ToString("+#;-#;0")
                        @<td>@Html.Raw(ns1)</td>
                    End Code
                </tr>
                        Next

        </table>
        <hr />
    </div>

<div class="col-xs-12">
        <!--COMP1-->
        <h2 class="owfont-big">PREMIER LOHKOT</h2>


        <h2 class="xtrafont2" style="text-align:left;">Lohko #3</h2>
        <table class="table table-bordered">
            <tr class="xtrafont3 hidden-xs">
                <th>
                    Kaupunki
                </th>
                <th>
                    Ottelut
                </th>
                <th>
                    W-D-L
                </th>
                <th class="hidden-xs">
                    RWon
                </th>
                <th class="hidden-xs">
                    RLose
                </th>
                <th>+-</th>
            </tr>
            <tr class="xtrafont3 visible-xs">
                <th>
                    Kaupunki
                </th>
                <th>
                    Ottelut
                </th>
                <th>
                    W-D-L
                </th>
                <th class="hidden-xs">
                    RWon
                </th>
                <th class="hidden-xs">
                    RLose
                </th>
                <th>+-</th>
            </tr>
            @For Each item In Model.Where(Function(i) i.Division.GetValueOrDefault = 3).OrderByDescending(Function(x) x.rndWins).ThenByDescending(Function(x) x.rndDraws).ThenBy(Function(x) x.rndLoses).ThenByDescending(Function(t) t.RndWon - t.RndLose)
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CityName)
        </td>
         <td>
             @Html.DisplayFor(Function(modelItem) item.GamesPlayed)
         </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.rndWins) - @item.rndDraws - @item.rndLoses
        </td>
        <td class="hidden-xs">
            @Html.DisplayFor(Function(modelItem) item.RndWon)
        </td>
        <td class="hidden-xs">
            @Html.DisplayFor(Function(modelItem) item.RndLose)
        </td>
        @Code
            Dim ns As Integer = 0
            ns = (Int(item.RndWon) - Int(item.RndLose))
            Dim ns1 As String = "x"
            ns1 = ns.ToString("+#;-#;0")
            @<td>@Html.Raw(ns1)</td>
        End Code
    </tr>
            Next

</table>
</div>





</div>