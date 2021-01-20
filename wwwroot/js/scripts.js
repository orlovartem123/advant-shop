$(document).ready(function () {
    let position = 0;
    const container = $('.slider-container');
    const track = $('.slider-track');
    const item = $('.slider-item');
    const itemWidth = item.width();
    const radio1 = $('#r1');
    const radio2 = $('#r2');
    const radio3 = $('#r3');
    const radio4 = $('#r4');

    let g41Position = 0;
    const hitsRight = $('#hitsRight');
    const hitsLeft = $('#hitsLeft');
    const g41Product = $('.g41-product');
    const g41ProductHidden = g41Product.length - 3;
    const g41MaxPosition = -((g41Product.width()+22) * g41ProductHidden);
    let g41Track = $('.g41-product-info');

    let g40Position=0;
    const noveltyRight=$('#noveltyRight');
    const noveltyLeft=$('#noveltyLeft');
    const g40Product = $('.g40-product');
    const g40ProductHidden = g40Product.length - 3;
    const g40MaxPosition = -((g40Product.width()+22) * g40ProductHidden);
    let g40Track = $('.g40-product-info');

    const dropListWrapper = $('#dlwb');
    let dropListBasket = $('#dlb');
    let selected = $('input[name=r]:checked').val();
    let isOnDropListWrapper = false;
    let isOnDropList = false;

    dropListWrapper.hover(function () {
        isOnDropListWrapper = true;
        dropListBasket.css({
            display: `block`
        });
    });

    dropListBasket.mouseenter(function () {
        if (isOnDropListWrapper) {
            isOnDropList = true;
            dropListBasket.css({
                display: `block`
            });
        }
    });

    dropListBasket.mouseleave(function () {
        if (isOnDropListWrapper) {
            isOnDropList = false;
            dropListBasket.css({
                display: `none`
            });
        }
    });

    dropListWrapper.mouseleave(function () {
        if (!isOnDropList) {
            dropListBasket.css({
                display: `none`
            });
        }
    });

    radio1.click(function () {
        if (selected === "1") {
            return;
        }
        setPosition(selected - 1);
    });

    radio2.click(function () {
        if (selected === "2") {
            return;
        }
        setPosition(selected - 2);
    });

    radio3.click(function () {
        if (selected === "3") {
            return;
        }
        setPosition(selected - 3);
    });

    radio4.click(function () {
        if (selected === "4") {
            return;
        }
        setPosition(selected - 4);
    });

    hitsRight.click(function () {
        if(g41Position===g41MaxPosition){
            return;
        }
        g41Position -= 286;
        g41Track.css({
            transform: `translateX(${g41Position}px)`
        });
    });

    hitsLeft.click(function () {
        if (g41Position === 0) {
            return;
        }
        g41Position += 286;
        g41Track.css({
            transform: `translateX(${g41Position}px)`
        });
    });

    noveltyRight.click(function () {
        if(g40Position===g40MaxPosition){
            return;
        }
        g40Position -= 286;
        g40Track.css({
            transform: `translateX(${g40Position}px)`
        });
    });

    noveltyLeft.click(function () {
        if (g40Position === 0) {
            return;
        }
        g40Position += 286;
        g40Track.css({
            transform: `translateX(${g40Position}px)`
        });
    });

    const setPosition = (newSelected) => {
        position += (newSelected * itemWidth);
        track.css({
            transform: `translateX(${position}px)`
        });
        selected = $('input[name=r]:checked').val();
    }

});

