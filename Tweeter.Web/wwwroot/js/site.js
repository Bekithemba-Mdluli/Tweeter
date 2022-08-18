// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function scrollNav() {
    $('.nav a').click(function () {
        $(".active").removeClass("active");
        $(this).addClass("active");

        $('html, body').stop().animate({
            scrollTop: $($(this).attr('href')).offset().top - 160
        }, 300);
        return false;
    });
}
scrollNav();