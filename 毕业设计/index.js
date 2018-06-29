$(function () {
    $('.loginname').focus(function () {
        $(this).attr('value', '');
        $(this).css('color', 'black');
    }), $('.loginname').blur(function () {
        $(this).attr('value', '请输入手机号码')
    })

    $('#Txtname').focus(function () {
        $(this).removeAttr('value');
        $(this).css('color', 'black');
    }), $('#Txtname').blur(function () {
        $(this).attr('value', '可输入中文或者英文或者数字,限8个字符');
        if ($('#Txtname').val().length > 0) {
            $('#tnl').css('display', 'none');
            return false;
        } else {
            $('#tnl').css('display', 'block');
        }
    })

    $('#Txtph').focus(function () {
        $(this).removeAttr('value');
        $(this).css('color', 'black');
    }), $('#Txtph').blur(function () {
        $(this).attr('value', '请输入正确手机号码');
        if ($('#Txtph').val().length > 0) {
            $('#phl').css('display', 'none');
            return false;
        } else {
            $('#phl').css('display', 'block');
        }

    })

    $('#Txtpwd').focus(function () {
        $(this).attr('value', '');
        $(this).css('color', 'black');
    }), $('#Txtpwd').blur(function () {
        $(this).attr('value', '可以输入数字或者字母,不能少于6个数字');


    })

    $('#btnagree').click(function () {
        if ($('#Txtname').val().length == 0) {
            $('#tnl').css('display', 'block');
            return false;
        }
        else {
            $('#tnl').css('display', 'none');
        }
        if ($('#Txtname').val() == "可输入中文或者英文或者数字,限8个字符") {
            $('#tnl').css('display', 'block');
            return false;
        }
        else {
            $('#tnl').css('display', 'none');
        }
        //用户名
    })

    //首页

    $(".buycar").hover(function () {
        $('.car').css('background-position', '-164px -38px');
        $('#shuliang').css('color', '#fff');
        $('#buys').slideDown(300);
    }, function () {
        $('.car').css('background-position', '-164px -20px');
        $('#shuliang').css('color', '#c20315');
        $('#buys').slideUp(300);
    })
    //管理员页面
    $('.ad_a').click(function () {
        $('.ad_pc').css('display', 'block');
        $('.ad_dingdan').css('display', 'none');
        $('.ad_zhangdan').css('display', 'none');
        $('.ad_yingyee').css('display', 'none');
    })

    $('.ad_b').click(function () {
        $('.ad_pc').css('display', 'none');
        $('.ad_dingdan').css('display', 'block');
        $('.ad_zhangdan').css('display', 'none');
        $('.ad_yingyee').css('display', 'none');
    })

    $('.ad_c').click(function () {
        $('.ad_pc').css('display', 'none');
        $('.ad_dingdan').css('display', 'none');
        $('.ad_zhangdan').css('display', 'block');
        $('.ad_yingyee').css('display', 'none');
    })

    $('.ad_d').click(function () {
        $('.ad_pc').css('display', 'none');
        $('.ad_dingdan').css('display', 'none');
        $('.ad_zhangdan').css('display', 'none');
        $('.ad_yingyee').css('display', 'block');
    })
    
})
