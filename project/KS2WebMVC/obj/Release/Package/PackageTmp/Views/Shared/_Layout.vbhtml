<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no">
    <meta name="mobile-web-app-capable" content="yes">
    <meta name="theme-color" content="#3c3c3c" />
    <meta name="apple-mobile-web-app-status-bar-style" content="black">
    <title>@ViewBag.Title | THE KAUPUNKISOTA</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet" type="text/css">
    <link href="https://fonts.googleapis.com/css?family=Saira+Extra+Condensed" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Fira+Mono" rel="stylesheet">
</head>

<body id="page-top" data-spy="scroll" data-target=".navbar-fixed-top" onload="consoleEgg();">
    <!-- Navigation -->
    <nav class="navbar navbar-custom navbar-fixed-top" role="navigation">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-main-collapse">
                    #! <i class="fa fa-bars"></i>
                </button>
                <a class="navbar-brand page-scroll" href="#page-top" style="font-size:25px;font-family:'bignoodletoo';">
                    The <span class="light">Kaupunkisota</span> 
                </a>
            </div>

            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class="collapse navbar-collapse navbar-right navbar-main-collapse">
                <ul class="nav navbar-nav" style="font-size:25px;">
                    <!-- Hidden li included to remove active class from about link when scrolled up past about section -->
                    <li class="hidden">
                        <a href="#page-top"></a>
                    </li>
                    <li>
                        <a class="page-scroll" href="#about">Info</a>
                    </li>
                    <li>
                        <a class="page-scroll" href="#scoreboards">Tulokset</a>
                    </li>
                    <li>
                        <a class="page-scroll" href="#matches">Ottelut</a>
                    </li>
                    <li>
                        <a class="page-scroll" href="#teams">Joukkueet</a>
                    </li>
                </ul>
            </div>
            <!-- /.navbar-collapse -->
        </div>
        <!-- /.container -->
    </nav>

        @RenderBody()

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
    <!--GA-->
    <script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','https://www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-74100218-3', 'auto');
  ga('send', 'pageview');

    </script>
    <script>
        function consoleEgg() {
            console.log(`#!Directoriino: You probably do not want to press the button at the bottom.`, );
        };
        function yesTheWholeThing() {
            $("#page-top").glitch('replace', {
                amount: 3
            });
        };

        function reload1() {
            $.ajax({

                url: '@Url.Action("ScoresLoad", "Home")',
            type:"GET",
            dataType: "html",
            //data: { id: 1 },//this is as per your requirement
            success: function (data) {
                $('#scoresdiv').html(data);
            },
            });

            $.ajax({

            url: '@Url.Action("MatchesLoad", "Home")',
            type:"GET",
            dataType: "html",
            //data: { id: 1 },//this is as per your requirement
            success: function (data) {
                $('#matchesdiv').html(data);
            },
            });

            $.ajax({

            url: '@Url.Action("TeamsLoad", "Home")',
            type:"GET",
            dataType: "html",
            //data: { id: 1 },//this is as per your requirement
            success: function (data) {
                $('#teamsdiv').html(data);
            },
            });
        }
    </script>
</body>
</html>
