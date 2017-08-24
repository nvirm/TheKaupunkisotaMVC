@Code
    ViewData("Title") = "Kausi 2"
End Code

 <!-- Intro Header -->
<header class="intro source" id="introdiv">
    <div class="intro-body target" id="introdiv2">
        <div class="container">
            <div class="row">
                <div class="col-md-8 col-md-offset-2">
                    <p class="intro-text" id="logo-orig">
                        <img style="max-width:100%;" src="~/Content/LogoSombrero.png" />  
                    </p>
                    <a href="#about" class="btn btn-circle page-scroll">
                        <i class="fa fa-crosshairs animated"></i>
                    </a>
                </div>
            </div>
        </div>
    </div>
</header>
<!--Reloadbutton-->
<button class="btn btn-primary xtrafont3 reloadbutton" onclick="reload1();">Päivitä</button>
<!-- About Section -->
<section id="about" class="container content-section text-center" style="padding-top:50px;">
    <div class="row">
        <div class="col-lg-12">
            <h2 class="owfont-big" style="color:#3f88a9;">Info</h2>
            @Html.Partial("_Info")
        </div>
    </div>
</section>
<hr class="style11"/>
<!--Scoreboards -->
<section id="scoreboards" class="container content-section text-center" style="padding-top:50px;">
    <div class="row">
            <div class="col-lg-12">
                <h2 class="owfont-big" style="color:#3f88a9;">Tulokset</h2> 
                    <div id="scoresdiv">
                        @Html.Partial("_Scores", New ksBotSQL2Entities().Scoreboard)
                    </div>
                </div>
    </div>
</section>
<hr class="style11" />
<!--Matches-->
<section id="matches" class="container content-section text-center" style="padding-top:50px;">
    <div class="row">
        <div class="col-lg-12">
            <h2 class="owfont-big" style="color:#3f88a9;">Ottelut</h2>
            <div id="matchesdiv">
                @Html.Partial("_Match", New ksBotSQL2Entities().Match)
            </div>
        </div>
    </div>
</section>
<hr class="style11" />
<!-- Teams Section -->
<section id="teams" class="container content-section text-center" style="padding-top:50px;">
    <div class="row">
        <div class="col-lg-12">
            <h2 class="owfont-big" style="color:#3f88a9;">Joukkueet</h2>
                <div id="teamsdiv">
                    @Html.Partial("_Team", New ksBotSQL2Entities().Team)
                </div>
        </div>
        
    </div>
</section>
<!--egg-->
<hr class="style11" />
<div Class="text-center" style="padding-top:25px;">
    <i Class="fa fa-exclamation-triangle" style="text-align:center;font-size:30px;color:#ff8500; padding-bottom:20px;" aria-hidden="true" onclick="yesTheWholeThing();"></i>
    <br/>
    <h3 Class="owfont-med">2017 ENVY.RED/KAUPUNKISOTA | OVERWATCH © 2017 BLIZZARD ENTERTAINMENT.</h3>
    <span class="xtrafont3" style="color:#3f88a9;"><a href="mailto:thekaupunkisota@gmail.com">Email</a> // <a href="https://twitter.com/thekaupunkisota">Twitter</a> // <a href="https://discord.gg/nd7zJRQ">The Kaupunkisota</a> // <a href="https://discord.gg/tKezvfH">SuomiOW Discord</a></span>
</div>
