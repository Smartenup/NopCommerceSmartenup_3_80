(function () {
    $(document).ready(function () {
        var responsiveAppSettings = {
            isEnabled: true,
            themeBreakpoint: 1000,
            isSearchBoxDetachable: true,
            isHeaderLinksWrapperDetachable: true,
            doesDesktopHeaderMenuStick: true,
            doesScrollAfterFiltration: true,
            doesSublistHasIndent: true,
            displayGoToTop: true,
            hasStickyNav: true,
            selectors: {
                menuTitle: ".menu-title",
                headerMenu: ".header-menu",
                closeMenu: ".close-menu",
                movedElements: ".admin-header-links, .header, .responsive-nav-wrapper, .slider-wrapper, .master-wrapper-content, .todays-poll-box, .newsletter, .footer",
                sublist: ".header-menu .sublist",
                overlayOffCanvas: ".overlayOffCanvas",
                withSubcategories: ".with-subcategories",
                filtersContainer: ".nopAjaxFilters7Spikes",
                filtersOpener: ".filters-button span",
                searchBoxOpener: ".search-wrap > span",
                searchBox: ".search-box.store-search-box",
                searchBoxBefore: ".desktop-cart",
                navWrapper: ".responsive-nav-wrapper",
                navWrapperParent: ".responsive-nav-wrapper-parent",
                headerLinksOpener: "#header-links-opener",
                headerLinksWrapper: ".header-links-wrapper",
                headerLinksWrapperMobileInsertAfter: ".header",
                headerLinksWrapperDesktopPrependTo: ".header-centering",
                shoppingCartLink: ".shopping-cart-link",
                overlayEffectDelay: 300
            }
        }
        
        sevenSpikes.initResponsiveTheme(responsiveAppSettings);

        $('.details-title').click(function () {
            $(this).toggleClass('open').next().toggle();
        });

    });
})();