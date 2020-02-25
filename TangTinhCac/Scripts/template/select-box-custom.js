/*Dropdown Menu*/
$('body').on('click', '#dropdown', function () {
    $(this).attr('tabindex', 1).focus();
    $(this).toggleClass('active');
    $(this).find('.dropdown-menu').slideToggle(300);
});

$('body').on('click', '#dropdown .dropdown-menu li', function () {
    $(this).parents('#dropdown').find('span').text($(this).text());
    $(this).parents('#dropdown').find('input').attr('value', $(this).attr('id'));
});

//$('body').on('click', '.dropdown-menu li', function () {
//    var input = '<strong>' + $(this).parents('#dropdown').find('input').val() + '</strong>',
//        msg = '<span class="msg">Hidden input value: ';
//    $('.msg').html(msg + input + '</span>');
//});

$('body').on('focusout', '#dropdown', function () {
    $(this).removeClass('active');
    $(this).find('.dropdown-menu').slideUp(300);
});

//
//$('#dropdown').click(function () {
//    $(this).attr('tabindex', 1).focus();
//    $(this).toggleClass('active');
//    $(this).find('.dropdown-menu').slideToggle(300);
//});
//$('#dropdown').focusout(function () {
//    $(this).removeClass('active');
//    $(this).find('.dropdown-menu').slideUp(300);
//});
//$('#dropdown .dropdown-menu li').click(function () {
//    $(this).parents('#dropdown').find('span').text($(this).text());
//    $(this).parents('#dropdown').find('input').attr('value', $(this).attr('id'));
//});
/*End Dropdown Menu*/


//$('.dropdown-menu li').click(function () {
//    var input = '<strong>' + $(this).parents('#dropdown').find('input').val() + '</strong>',
//        msg = '<span class="msg">Hidden input value: ';
//    $('.msg').html(msg + input + '</span>');
//}); 