let u = document.getElementsByTagName("ul")[0];
let d = document.getElementsByTagName("img")[0];
let h = document.getElementsByTagName("header")[0];

window.addEventListener("load", function () {
    u.style.animation = "navOut 1s";
    u.style.animationFillMode = "forwards";
    d.style.animation = "rotIn 0";
    d.style.animationFillMode = "forwards";
});

h.addEventListener("mouseover", function() {
    u.style.animation = "navIn 1s";
    u.style.animationFillMode = "forwards";
    d.style.animation = "rotIn 1s";
    d.style.animationFillMode = "forwards";

    h.style.animation = "navInH 0.25s";
    h.style.animationFillMode = "forwards";
});
h.addEventListener("mouseout", function() {
    u.style.animation = "navOut 1s";
    u.style.animationFillMode = "forwards";
    d.style.animation = "rotOut 1s";
    d.style.animationFillMode = "forwards";

    h.style.animation = "navOutH 0.25s";
    h.style.animationFillMode = "forwards";
});