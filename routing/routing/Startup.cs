﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using System.Collections.Specialized;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing; // ПИ для маршрутизации
namespace WebApplication21 // Демо шаблонов маршрутов
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting(); // прикручиваем сервис для использования маршрутизации
        }

        public void Configure(IApplicationBuilder app)
        {
            var routeBuilder = new RouteBuilder(app);

            // Конкретный маршрут
            routeBuilder.MapRoute("Products/Tech/Mobile", async context =>
            {
                await context.Response.WriteAsync("Mobile");
            });

            /*routeBuilder.MapRoute("{page=Items}/Tech/Mobile", async context => {
                await context.Response.WriteAsync("Mobile value default");
            });*/

            // Третий параметр может быть произвольным
            routeBuilder.MapRoute("Index", async context => {
                await context.Response.WriteAsync("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n  <meta charset=\"UTF-8\">\r\n  <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n  <title>Document</title>\r\n  <style>\r\n    body{\r\n      padding: 0;\r\n      margin: 0;\r\n    }\r\n    header{\r\n      width: 100%;\r\n      background-color: lightblue;\r\n      \r\n    }\r\n    li{\r\n      display: inline-block;\r\n      margin: 10px;\r\n      font-size: 20px;\r\n      font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;\r\n      transition-duration:0.5s;\r\n      \r\n    }\r\n    li:hover{\r\n      transform: scale(1.1);\r\n    }\r\n    header a{\r\n        text-decoration: none;\r\n        color: black;\r\n        font-weight: bold;\r\n    }\r\n    \r\n    .header-wrap{\r\n      width: 80%;\r\n      margin: 0 auto;\r\n      display: flex;\r\n      justify-content: center;\r\n    }\r\n  </style>\r\n</head>\r\n<body>\r\n    <header>\r\n      <div class=\"header-wrap\">\r\n        <nav>\r\n          <ul class=\"main-nav\">\r\n            <li class=\"nav-itm\"><a href=\"Index\">Home</a></li>\r\n            <li class=\"nav-itm\"><a href=\"Index/Gallery\">Gallery</a></li>\r\n            <li class=\"nav-itm\"><a href=\"Index/AboutUs\">About us</a></li>\r\n            <li class=\"nav-itm\"><a href=\"Index/UsefulInfo\">Useful Info</a></li>\r\n            <li class=\"nav-itm\"><a href=\"Index/Contacts\">Contacts</a></li>\r\n          </ul>\r\n        </nav>\r\n      </div>\r\n      \r\n    </header>\r\n</body>\r\n</html>");
            });

            // Второй параметр может быть произвольным
            routeBuilder.MapRoute("Index/AboutUs", async context => {
                await context.Response.WriteAsync("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n  <meta charset=\"UTF-8\">\r\n  <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n  <title>Document</title>\r\n  <style>\r\n    body{\r\n      padding: 0;\r\n      margin: 0;\r\n    }\r\n    header{\r\n      width: 100%;\r\n      background-color: lightblue;\r\n      \r\n    }\r\n    li{\r\n      display: inline-block;\r\n      margin: 10px;\r\n      font-size: 20px;\r\n      font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;\r\n      transition-duration:0.5s;\r\n      \r\n    }\r\n    li:hover{\r\n      transform: scale(1.1);\r\n    }\r\n    header a{\r\n        text-decoration: none;\r\n        color: black;\r\n        font-weight: bold;\r\n    }\r\n    \r\n    .header-wrap{\r\n      width: 80%;\r\n      margin: 0 auto;\r\n      display: flex;\r\n      justify-content: center;\r\n    }\r\n    main{\r\n      background-color: cadetblue ;\r\n    }\r\n    .container{\r\n      \r\n      display: grid;\r\n      width: 100%;\r\n      grid-template-columns: 1fr 1fr 1fr;\r\n      grid-auto-rows: auto;\r\n      justify-content: center;\r\n      grid-gap: 10px;\r\n\r\n    }\r\n    img{\r\n      width: 300px;\r\n      height: 300px;\r\n    }\r\n    .grid-item{\r\n      display: inline-block;\r\n      \r\n      height: 300px;\r\n      width: 300px;\r\n    }\r\n    p{\r\n      padding: 10px;\r\n      font-size: 18px;\r\n      font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;\r\n    }\r\n  </style>\r\n</head>\r\n<body>\r\n    <header>\r\n      <div class=\"header-wrap\">\r\n        <nav>\r\n          <ul class=\"main-nav\">\r\n            <li class=\"nav-itm\"><a href=\"Index\">Home</a></li>\r\n            <li class=\"nav-itm\"><a href=\"Index/Gallery\">Gallery</a></li>\r\n            <li class=\"nav-itm\"><a href=\"Index/AboutUs\">About us</a></li>\r\n            <li class=\"nav-itm\"><a href=\"Index/UsefulInfo\">Useful Info</a></li>\r\n            <li class=\"nav-itm\"><a href=\"Index/Contacts\">Contacts</a></li>\r\n          </ul>\r\n        </nav>\r\n      </div>\r\n      \r\n    </header>\r\n    <main>\r\n      <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Obcaecati at odit id reiciendis voluptatum perspiciatis rerum ad non! Sunt, quam pariatur corporis quisquam vel reprehenderit minus in sint ipsa, facilis iste assumenda culpa ipsam alias asperiores dolorum. Officiis eos dolore ad quis? Soluta voluptates illo sequi recusandae libero nemo dolores modi molestias quia molestiae magni, aliquam, corporis asperiores fugit. Repellat similique sunt accusantium, vitae minus omnis obcaecati officiis quod aut cum. Architecto, exercitationem perferendis omnis perspiciatis facilis aliquam eaque expedita quam deleniti! Eveniet labore maiores placeat doloribus mollitia velit, nam laborum laudantium magnam hic dolor quidem enim repudiandae laboriosam eos atque, iusto illum deleniti reiciendis. Dolores velit quae, optio ipsa eligendi possimus ratione magnam magni dolor esse illo, voluptate debitis obcaecati quibusdam quasi iure, animi repellat deserunt nemo sunt tempora unde labore. Pariatur vitae id, ad incidunt error, aut maiores ab accusantium necessitatibus, laborum inventore! Aperiam, nemo ducimus! Mollitia dolores, laboriosam explicabo assumenda quaerat, fuga fugit aliquam quae cumque ducimus delectus culpa odit cupiditate sed ut porro laborum non, molestias adipisci. Necessitatibus quam explicabo commodi unde non? Perspiciatis quibusdam cupiditate porro tempora optio, voluptatibus ratione, earum repellat omnis voluptatum odit. Quo rerum explicabo, totam exercitationem corrupti, qui et molestiae alias aliquam doloribus mollitia sint. Voluptatem, tempore vitae saepe repudiandae hic ex consequuntur repellat provident magnam a, adipisci omnis minima maxime nihil incidunt facilis, dolor obcaecati debitis officiis dolores soluta! Ipsam impedit temporibus sit doloremque vero laboriosam in, nemo at eaque incidunt quibusdam quo esse aut minima sapiente praesentium mollitia a similique quas. Modi veritatis quibusdam dolore praesentium aperiam, fugiat dignissimos. Odit cupiditate maiores beatae laboriosam consequuntur, eaque exercitationem modi adipisci facilis. Eum assumenda veritatis perspiciatis velit obcaecati consequuntur fuga error tempore neque. Vitae voluptas excepturi vero rerum. Voluptatibus temporibus alias, deleniti officiis veritatis, culpa tempora iure consequuntur omnis in est? Minima ratione laboriosam consequatur similique pariatur beatae corrupti quaerat explicabo quo ut eos libero magni fuga placeat, doloribus ab reiciendis sit minus numquam. Iure modi atque corrupti ipsam officia minima, dolor ad deserunt amet consectetur doloremque quisquam reprehenderit! Doloremque pariatur illo a, consequuntur quasi nulla voluptate quis aliquam? Veniam culpa dignissimos, impedit laborum modi assumenda? Odio numquam dolores, dolorem, animi perspiciatis optio debitis, dolorum at eveniet nisi sit provident voluptatem. Porro beatae vel ullam dolorem consequatur voluptatem fugiat quia totam, explicabo animi ipsum maiores nisi eos soluta esse odio, itaque natus deserunt expedita doloremque doloribus! Inventore, necessitatibus iste, non obcaecati vitae, minima fuga deleniti aspernatur incidunt at explicabo. Possimus ut veritatis quidem qui iste, dignissimos necessitatibus eum corrupti quas asperiores nobis itaque corporis tempora esse reiciendis est dolorem voluptate adipisci eaque quia neque placeat ullam? Tempora, vero ducimus? Quasi id minus laboriosam nihil quo cum totam corporis tenetur reprehenderit, ad velit at. Aut quidem reprehenderit nesciunt officia possimus nulla totam, ea, modi tenetur accusantium illo temporibus doloribus provident nisi non perferendis mollitia laudantium! Rerum doloremque fugiat itaque sint repellat dolorum, deserunt molestias laborum nesciunt, reprehenderit vero. Quod repudiandae aspernatur sint ad facere aperiam, nostrum voluptas libero magnam accusantium dolores nemo. Lorem ipsum dolor sit amet consectetur adipisicing elit. Aliquam sequi et dignissimos atque, ab adipisci. Quod architecto autem sequi adipisci sit mollitia asperiores saepe in inventore quaerat. Sapiente illum nemo sit voluptatibus esse? Quisquam voluptatem eaque maiores quis laborum! Non asperiores vitae quam voluptatum, officia blanditiis labore rerum unde, numquam minus beatae, pariatur dolor. Deserunt doloremque atque non ipsa nulla. Nesciunt quod, voluptatibus reiciendis quos cupiditate distinctio ratione culpa suscipit, impedit voluptas natus amet aut? Possimus veritatis aspernatur natus magni, rem dolore facilis quia veniam hic incidunt. Dolorum repellat iusto excepturi officia velit molestias fugit veniam deleniti aut a ratione quia impedit, dignissimos laboriosam blanditiis. Earum voluptatem eius exercitationem ducimus ullam quidem. A ratione, harum amet officiis minus quibusdam accusantium, obcaecati eaque officia dolore sit ipsam excepturi. Officia perferendis ex nostrum ipsum illo ab optio accusamus facere labore ut, iusto minima numquam eius. Optio, dolore cumque. Quidem officia tenetur maiores quisquam error. Accusantium nobis nemo assumenda quam quos magni labore rem qui consequuntur excepturi laboriosam quisquam quae nulla alias, adipisci voluptates totam illum? Officia laboriosam ut ab voluptatum voluptas error tenetur. Ea cumque animi, vitae non, doloribus nisi praesentium cupiditate repudiandae natus quas porro cum magni exercitationem! Suscipit nobis voluptatem assumenda unde cumque accusantium delectus aperiam nesciunt. Repellat, quasi! Voluptatem doloremque inventore reiciendis provident ratione. Explicabo quasi dolorum voluptate! Doloribus alias libero explicabo nostrum qui eum possimus commodi, praesentium nemo mollitia ea ab magni voluptates? Consequatur omnis excepturi exercitationem dicta sint voluptatum consequuntur voluptatibus suscipit, ullam dolor incidunt blanditiis praesentium saepe? Totam qui cum unde iure ipsa labore, ipsam reprehenderit mollitia dolores, quisquam nulla aliquam molestias beatae magni! Minima quia assumenda asperiores? Eveniet ducimus soluta quas magni excepturi aperiam distinctio mollitia, placeat temporibus nemo eaque culpa ratione sequi voluptate, animi neque hic unde rem. Et voluptas possimus nostrum, vitae quod saepe, quos officiis necessitatibus aperiam deserunt sunt aut quam molestias, quia quis dolorum id officia! Nostrum fugit praesentium nam illum veniam autem nesciunt eaque necessitatibus, sunt assumenda maiores hic porro commodi ratione modi quam aspernatur animi corrupti molestiae, optio incidunt neque id. Nihil maiores veritatis fugit, minus rerum aliquam dolorem eum ipsum molestias magnam cupiditate minima eligendi illo alias velit vero est, odio iure nisi impedit non, dignissimos porro quod. Placeat, eveniet. Perferendis consectetur dolores officia atque sunt explicabo recusandae aperiam odio quod officiis! Quod amet unde repudiandae enim distinctio earum iusto vitae error quia nesciunt sit assumenda suscipit cumque deleniti dignissimos ipsum, eligendi inventore! Saepe doloribus, suscipit autem eveniet soluta possimus alias nulla facilis! Pariatur quasi aliquam culpa. Adipisci culpa quo, architecto necessitatibus magni repellendus quasi non sit amet veritatis at saepe hic tempora totam ab fugit, fugiat accusamus nobis unde nisi illum! Qui quae obcaecati voluptatibus sunt? Totam, nobis ipsum! Reprehenderit commodi veritatis a, totam dolores rem doloribus quos itaque numquam impedit praesentium culpa, modi mollitia inventore maxime aliquid quam molestiae deleniti eum sequi hic esse! Expedita harum tenetur adipisci iusto iste possimus tempore obcaecati maiores ab accusantium! Enim ducimus repellat eius quasi ratione distinctio inventore eum, nostrum assumenda! Laboriosam aut, quis ut at, eum tenetur autem aperiam perspiciatis debitis iste doloremque omnis consectetur dignissimos voluptatem earum nulla, ad ipsum? Dolorum aspernatur earum fuga autem? Fuga ullam cupiditate ex sed, consequuntur molestias, laboriosam tempora delectus dignissimos alias cum quia nesciunt at fugit commodi suscipit quaerat repudiandae ratione. Autem quaerat debitis repellat fugiat sapiente obcaecati sunt veniam odit! Cupiditate minima itaque quod maiores consequatur pariatur repellat voluptatem a, sequi excepturi repudiandae commodi dolores odit vitae eligendi, maxime aperiam earum, provident laboriosam veniam nisi necessitatibus voluptates? Vel voluptatibus, sit earum modi distinctio ad non quisquam optio eos error, quasi aliquid sunt veniam aut neque, quod quam. Nihil reprehenderit rerum laboriosam nam ut soluta commodi deserunt in repellendus? Fuga odit ducimus repudiandae eligendi ad corporis laborum sit, ab quo suscipit nisi eum enim quisquam nesciunt sapiente. Atque soluta, tenetur adipisci nobis animi omnis? Suscipit, expedita accusamus beatae doloremque ea fuga velit itaque, reiciendis, voluptatibus unde nam. Sit porro est labore perspiciatis aperiam itaque modi, hic ipsam et optio beatae cum. A quasi autem voluptatem facere molestiae! Porro non aperiam molestiae animi iusto minus harum recusandae magni autem. Voluptates corporis et esse! Obcaecati ullam, laudantium quas soluta amet odit? Vel neque harum nesciunt fugiat deserunt incidunt, suscipit eum, aperiam dolor voluptatibus explicabo rerum dolores ad perferendis eaque quo voluptate. Facilis ab ex autem provident. Neque aspernatur quidem, a tenetur doloremque tempora tempore saepe eius corrupti numquam dolore sint earum voluptates enim suscipit laboriosam consectetur facilis maiores possimus quaerat. Dolore blanditiis libero eaque ratione assumenda molestiae distinctio! Id provident tempore, sapiente eaque ducimus veritatis ea magnam optio vero? Dignissimos iusto nulla veniam harum laudantium nihil accusantium, enim amet aliquid beatae nemo, ea mollitia commodi cumque numquam? Laboriosam ut iste id blanditiis voluptatibus quos eum? Facere provident hic porro perferendis quisquam dolorem quae quas atque minus aliquid enim quidem vitae, assumenda harum amet veniam itaque saepe beatae esse nobis error maiores voluptas? Eum rerum, consequuntur quod porro perspiciatis molestiae at distinctio? Ex illo fugit, vitae cumque nisi ratione quas itaque asperiores velit quisquam, ut qui exercitationem, quo molestiae nihil aut beatae repudiandae accusamus. Adipisci nesciunt, incidunt cupiditate aliquam optio repellat tempore deserunt nulla aperiam, suscipit id? Error quod earum odio nostrum distinctio, cum voluptates velit a soluta nulla quisquam debitis, quia autem nesciunt quos at nihil sed minima illum laudantium. Dicta similique qui quaerat asperiores, nulla labore hic maxime excepturi quis eos ab minima cumque quod pariatur sit? Eveniet, deleniti? Deserunt quam exercitationem laboriosam eaque vel, odio commodi expedita cumque, accusantium veritatis maiores non. Nemo ex rem quas ad ea perferendis assumenda hic deserunt. Ducimus dolore commodi dolorem odit, magni eligendi in, architecto mollitia magnam harum minus. Ratione quam, repellat illo, eum dolorum asperiores totam aliquam reprehenderit amet enim saepe? Dignissimos, quas error porro, ipsum tenetur laborum sit assumenda rerum, pariatur maxime enim! Pariatur modi facere deserunt expedita fuga non laboriosam fugit architecto hic libero molestiae minima, itaque error dolor doloremque. Architecto ad iusto rerum assumenda, iste minima nobis porro ut illum quia veritatis!</p>\r\n    </main>\r\n</body>\r\n</html>");
            });

            // сюда попадаем, если пользователь ввел localhost/Какой-топуть1
            routeBuilder.MapRoute("{page=Items}/Gallery", async context => {
                await context.Response.WriteAsync("  <!DOCTYPE html>\r\n  <html lang=\"en\">\r\n  <head>\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Document</title>\r\n  \r\n      <link rel=\"stylesheet\"\r\n          href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\" integrity=\"sha384-\r\n          BVYiiSIFeKidGmJRAkycuHAHRg320mUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u\" cross origin=\"anonymous\">\r\n\r\n            <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap- theme.min.css\" integrity=\"sha384-rHyoN1iRsVXV4nDeJutinGasLCJu7uwjduw9SVrLvRYooPp2bWYgmgJQIXwl/Sp\"\r\n            crossorigin=\"anonymous\">\r\n            \r\n            <script src=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js\" integrity=\"sha384-Tc5IQ1b027qvyjSMfHjMaLkfuWVXZxUPCJA712mCWNIG9mGCDBWGNICPD7Txa\"\r\n          crossorigin=\"anonymous\"></script>\r\n    <style>\r\n      body{\r\n        padding: 0;\r\n        margin: 0;\r\n        position: sticky;\r\n        background-color: aqua;\r\n      }\r\n      header{\r\n        width: 100%;\r\n        background-color: lightblue;\r\n        position: fixed;\r\n        \r\n      }\r\n      .nav-itm{\r\n        display: inline-block;\r\n        margin: 10px;\r\n        font-size: 20px;\r\n        font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;\r\n        transition-duration:0.5s;\r\n        position: sticky;\r\n      \r\n        \r\n      }\r\n      .header {z-index: 500;}\r\n      .nav-itm:hover{\r\n        transform: scale(1.1);\r\n      }\r\n      header a{\r\n          text-decoration: none;\r\n          color: black;\r\n          font-weight: bold;\r\n      }\r\n      \r\n      .header-wrap{\r\n      \r\n        width: 80%;\r\n        margin: 0 auto;\r\n        display: flex;\r\n        justify-content: center;\r\n      }\r\n      main{\r\n        background-color: cadetblue;\r\n        \r\n        \r\n      }\r\n      .container{\r\n        display: inline-grid;\r\n        grid-template-columns: 300px 300px 300px;\r\n        margin-top: 100 px;\r\n        \r\n        \r\n\r\n      }\r\n      \r\n      .center{\r\n        text-align: center;\r\n      }\r\n      img{\r\n        width: 300px;\r\n        height: auto;\r\n      }\r\n      p{\r\n        width: 100vw;\r\n        font-size: 18px;\r\n        text-align: center;\r\n        font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;\r\n        font-weight: bold;\r\n      }\r\n      .solid{\r\n        padding-left: 10px;\r\n        font-size: 18px;\r\n        font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;\r\n      }\r\n      #up{z-index: 1000;}\r\n    </style>\r\n  </head>\r\n  <body>\r\n      <header id=\"up\">\r\n        <div class=\"header-wrap\">\r\n          <nav>\r\n            <ul class=\"main-nav\">\r\n              <li class=\"nav-itm\"><a href=\"#\">Home</a></li>\r\n              <li class=\"nav-itm\"><a href=\"Gallery\">Gallery</a></li>\r\n              <li class=\"nav-itm\"><a href=\"Index/AboutUs\">About us</a></li>\r\n              <li class=\"nav-itm\"><a href=\"Index/UsefulInfo\">Useful Info</a></li>\r\n              <li class=\"nav-itm\"><a href=\"Index/Contacts\">Contacts</a></li>\r\n            </ul>\r\n          </nav>\r\n            \r\n        </div>\r\n        \r\n        \r\n      </header>\r\n      <main id=\"down\">\r\n        <div class=\"container-fluid\" id=\"pictures\">\r\n          <div class=\"row\" style=\"margin-top:300px;\">\r\n            <div class=\"col-md-4\"><img src=\"https://www.proplan.ru/sites/owners.proplan.ru/files/styles/image_768x307/public/2021-12/kitten_1920.jpg?itok=6uLtVCJM\"></div>\r\n            <div class=\"col-md-4\"><img src=\"https://www.purinaone.ru/cat/sites/default/files/styles/image_576/public/2020-08/norma_0.jpg?itok=fQPH71_P\"></div>\r\n            <div class=\"col-md-4\"><img src=\"https://www.proplan.ru/sites/owners.proplan.ru/files/styles/image_768x307/public/2021-12/kitten_1920.jpg?itok=6uLtVCJM\"></div>\r\n            <div class=\"col-md-4\"><img src=\"https://s2.stc.all.kpcdn.net/woman/wp-content/uploads/2022/01/kittens-555822_1920-960x540.jpg\"></div>\r\n            <div class=\"col-md-4\"><img src=\"https://pic.rutubelist.ru/user/2c/a8/2ca83933b204def67fc3b9f268afa878.jpg\"></div>\r\n            <div class=\"col-md-4\"><img src=\"https://www.proplan.ru/sites/owners.proplan.ru/files/styles/image_768x307/public/2021-04/%D1%87%D1%82%D0%BE%20%D0%BA%D1%83%D0%BF%D0%B8%D1%82%D1%8C%20%D0%B4%D0%BB%D1%8F%20%D0%BA%D0%BE%D1%82%D0%B5%D0%BD%D0%BA%D0%B0_%D0%B3%D0%BB%D0%B0%D0%B2%D0%BD%D0%B0%D1%8F%20%281%29.jpg?itok=aBN8b2QM\"></div>\r\n          </div>\r\n          \r\n        </div>\r\n      </main>\r\n    \r\n    \r\n    \r\n      \r\n  </body>\r\n  </html>");
            });

            // сюда попадаем, если пользователь ввел localhost/Какой-топуть1/Какой-топуть2
            routeBuilder.MapRoute("Index/Contacts", async context =>
            {
                await context.Response.WriteAsync("  <!DOCTYPE html>\r\n  <html lang=\"en\">\r\n  <head>\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Document</title>\r\n  \r\n      <link rel=\"stylesheet\"\r\n          href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\" integrity=\"sha384-\r\n          BVYiiSIFeKidGmJRAkycuHAHRg320mUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u\" cross origin=\"anonymous\">\r\n\r\n            <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap- theme.min.css\" integrity=\"sha384-rHyoN1iRsVXV4nDeJutinGasLCJu7uwjduw9SVrLvRYooPp2bWYgmgJQIXwl/Sp\"\r\n            crossorigin=\"anonymous\">\r\n            \r\n            <script src=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js\" integrity=\"sha384-Tc5IQ1b027qvyjSMfHjMaLkfuWVXZxUPCJA712mCWNIG9mGCDBWGNICPD7Txa\"\r\n          crossorigin=\"anonymous\"></script>\r\n    <style>\r\n      body{\r\n        padding: 0;\r\n        margin: 0;\r\n        position: sticky;\r\n        background-color: aqua;\r\n      }\r\n      header{\r\n        width: 100%;\r\n        background-color: lightblue;\r\n        position: fixed;\r\n        \r\n      }\r\n      .nav-itm{\r\n        display: inline-block;\r\n        margin: 10px;\r\n        font-size: 20px;\r\n        font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;\r\n        transition-duration:0.5s;\r\n        position: sticky;\r\n      \r\n        \r\n      }\r\n      .header {z-index: 500;}\r\n      .nav-itm:hover{\r\n        transform: scale(1.1);\r\n      }\r\n      header a{\r\n          text-decoration: none;\r\n          color: black;\r\n          font-weight: bold;\r\n      }\r\n      \r\n      .header-wrap{\r\n      \r\n        width: 80%;\r\n        margin: 0 auto;\r\n        display: flex;\r\n        justify-content: center;\r\n      }\r\n      main{\r\n        background-color: cadetblue;\r\n        \r\n        \r\n      }\r\n      .container{\r\n        display: inline-grid;\r\n        grid-template-columns: 300px 300px 300px;\r\n        margin-top: 100 px;\r\n        \r\n        \r\n\r\n      }\r\n      \r\n      .center{\r\n        text-align: center;\r\n      }\r\n      img{\r\n        width: 300px;\r\n        height: auto;\r\n      }\r\n      p{\r\n        width: 100vw;\r\n        font-size: 18px;\r\n        text-align: center;\r\n        font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;\r\n        font-weight: bold;\r\n      }\r\n      .solid{\r\n        padding-left: 10px;\r\n        font-size: 18px;\r\n        font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;\r\n      }\r\n      #up{z-index: 1000;}\r\n    </style>\r\n  </head>\r\n  <body>\r\n      <header id=\"up\">\r\n        <div class=\"header-wrap\">\r\n          <nav>\r\n            <ul class=\"main-nav\">\r\n              <li class=\"nav-itm\"><a href=\"#\">Home</a></li>\r\n              <li class=\"nav-itm\"><a href=\"Gallery\">Gallery</a></li>\r\n              <li class=\"nav-itm\"><a href=\"Index/AboutUs\">About us</a></li>\r\n              <li class=\"nav-itm\"><a href=\"Index/UsefulInfo\">Useful Info</a></li>\r\n              <li class=\"nav-itm\"><a href=\"Index/Contacts\">Contacts</a></li>\r\n            </ul>\r\n          </nav>\r\n            \r\n        </div>\r\n        \r\n        \r\n      </header>\r\n      <main id=\"down\">\r\n        <div class=\"container-fluid\" id=\"pictures\">\r\n          <div class=\"row\">\r\n            <div class=\"col-md-12\"><p><img src=\"https://i.ibb.co/c1YXPDv/photo-2022-12-01-11-55-28.jpgs\"></p></div>\r\n          </div>\r\n          \r\n        </div>\r\n      </main>\r\n    \r\n    \r\n    \r\n      \r\n  </body>\r\n  </html>");
            });

            // сюда попадаем, если пользователь ввел localhost/Какой-топуть1/Какой-топуть2/Какой-топуть3
            routeBuilder.MapRoute("Index/UsefulInfo", async context => {
                await context.Response.WriteAsync("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n  <meta charset=\"UTF-8\">\r\n  <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n  <title>Document</title>\r\n  <style>\r\n    body{\r\n      padding: 0;\r\n      margin: 0;\r\n    }\r\n    header{\r\n      width: 100%;\r\n      background-color: lightblue;\r\n      \r\n    }\r\n    .nav-itm{\r\n      display: inline-block;\r\n      margin: 10px;\r\n      font-size: 20px;\r\n      font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;\r\n      transition-duration:0.5s;\r\n      \r\n    }\r\n    .nav-itm:hover{\r\n      transform: scale(1.1);\r\n    }\r\n    header a{\r\n        text-decoration: none;\r\n        color: black;\r\n        font-weight: bold;\r\n    }\r\n    \r\n    .header-wrap{\r\n      width: 80%;\r\n      margin: 0 auto;\r\n      display: flex;\r\n      justify-content: center;\r\n    }\r\n    main{\r\n      background-color: cadetblue ;\r\n      position: absolute;\r\n    }\r\n    .container{\r\n      \r\n      display: grid;\r\n      width: 100%;\r\n      grid-template-columns: 1fr 1fr 1fr;\r\n      grid-auto-rows: auto;\r\n      justify-content: center;\r\n      grid-gap: 10px;\r\n\r\n    }\r\n    img{\r\n      width: 300px;\r\n      height: 300px;\r\n    }\r\n    footer{\r\n      \r\n    }\r\n    .grid-item{\r\n      display: inline-block;\r\n      \r\n      height: 300px;\r\n      width: 300px;\r\n    }\r\n    p{\r\n      padding-left: 50px;\r\n      font-size: 18px;\r\n      font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;\r\n    }\r\n    .solid{\r\n      padding-left: 10px;\r\n      font-size: 18px;\r\n      font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;\r\n    }\r\n  </style>\r\n</head>\r\n<body>\r\n    <header>\r\n      <div class=\"header-wrap\">\r\n        <nav>\r\n          <ul class=\"main-nav\">\r\n            <li class=\"nav-itm\"><a href=\"Index\">Home</a></li>\r\n            <li class=\"nav-itm\"><a href=\"Index/Gallery\">Gallery</a></li>\r\n            <li class=\"nav-itm\"><a href=\"Index/AboutUs\">About us</a></li>\r\n            <li class=\"nav-itm\"><a href=\"Index/UsefulInfo\">Useful Info</a></li>\r\n            <li class=\"nav-itm\"><a href=\"Index/Contacts\">Contacts</a></li>\r\n          </ul>\r\n        </nav>\r\n      </div>\r\n      \r\n    </header>\r\n    <main>\r\n      <p>In software engineering, SOLID is a mnemonic acronym for five design principles intended to make object-oriented designs more understandable, flexible, and maintainable. The principles are a subset of many principles promoted by American software engineer and instructor Robert C. Martin,[1][2][3] first introduced in his 2000 paper Design Principles and Design Patterns discussing software development rot.[2][4]: 2–3 <p>\r\n\r\n        \r\n        <ul>\r\n          <li class=\"solid\">The SOLID ideas are</li>\r\n          <li class=\"solid\">The Single-responsibility principle: \"There should never be more than one reason for a class to change.\"[5] In other words, every class should have only one responsibility.[6]</li>\r\n          <li class=\"solid\">The Open–closed principle: \"Software entities ... should be open for extension, but closed for modification.\"[7]</li>\r\n          <li class=\"solid\">The Liskov substitution principle: \"Functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it.\"[8] See also design by contract.[8]</li>\r\n          <li class=\"solid\">The Interface segregation principle: \"Clients should not be forced to depend upon interfaces that they do not use.\"[9][4]</li>\r\n          <li class=\"solid\">The Dependency inversion principle: \"Depend upon abstractions, [not] concretions.\"[10][4]</li>\r\n        </ul>\r\n        <p>Although the SOLID principles apply to any object-oriented design, they can also form a core philosophy for methodologies such as agile development or adaptive software development.[3]\r\n        \r\n       </p>\r\n    </main>\r\n    \r\n</body>\r\n</html>");
            });



            app.UseRouter(routeBuilder.Build());

            // Сюда попадаем, если ни один из маршрутов не оказался подходящим
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n  <meta charset=\"UTF-8\">\r\n  <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n  <title>Document</title>\r\n  <style>\r\n    body{\r\n      padding: 0;\r\n      margin: 0;\r\n    }\r\n    header{\r\n      width: 100%;\r\n      background-color: lightblue;\r\n      \r\n    }\r\n    li{\r\n      display: inline-block;\r\n      margin: 10px;\r\n      font-size: 20px;\r\n      font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;\r\n      transition-duration:0.5s;\r\n      \r\n    }\r\n    li:hover{\r\n      transform: scale(1.1);\r\n    }\r\n    header a{\r\n        text-decoration: none;\r\n        color: black;\r\n        font-weight: bold;\r\n    }\r\n    \r\n    .header-wrap{\r\n      width: 80%;\r\n      margin: 0 auto;\r\n      display: flex;\r\n      justify-content: center;\r\n    }\r\n  </style>\r\n</head>\r\n<body>\r\n    <header>\r\n      <div class=\"header-wrap\">\r\n        <nav>\r\n          <ul class=\"main-nav\">\r\n            <li class=\"nav-itm\"><a href=\"Index\">Home</a></li>\r\n            <li class=\"nav-itm\"><a href=\"Index/Gallery\">Gallery</a></li>\r\n            <li class=\"nav-itm\"><a href=\"Index/AboutUs\">About us</a></li>\r\n            <li class=\"nav-itm\"><a href=\"Index/UsefulInfo\">Useful Info</a></li>\r\n            <li class=\"nav-itm\"><a href=\"Index/Contacts\">Contacts</a></li>\r\n          </ul>\r\n        </nav>\r\n      </div>\r\n      \r\n    </header>\r\n</body>\r\n</html>");
            });
        }

    }
}