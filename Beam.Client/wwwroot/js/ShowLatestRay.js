window.ShowLatestRay = {
    findFirstRayAndHighlight: function (element) {
        element.firstElementChild.animate([
            { transform: 'rotate(360deg)' }
        ], {
            duration: 1000,
            iterations: 2
        });
    }
}