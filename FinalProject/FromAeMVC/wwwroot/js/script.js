$(document).ready(function(){
    $(".new-block").children().hover(function(){
        $(".plus").toggle();
    })

    $(".bounceInLeft1").hover(function(){
        $(this).children("#thiss").toggle("animated fadeInOut d-block")
    })
})

    // owl-carousel
    $('.owl-carousel').owlCarousel({
        loop: true,
        margin: 10,
        nav: true,
        responsive: {
            0: {
                items: 4
            },
            600: {
                items: 4
            },
            1000: {
                items: 4
            }
        }
    })


    //hamburger

    //scroll-top
    var btn = $('#button');

$(window).scroll(function() {
  if ($(window).scrollTop() > 300) {
    btn.addClass('show');
  } else {
    btn.removeClass('show');
  }
});

btn.on('click', function(e) {
  e.preventDefault();
  $('html, body').animate({scrollTop:0}, '300');
});
    //scroll-top


