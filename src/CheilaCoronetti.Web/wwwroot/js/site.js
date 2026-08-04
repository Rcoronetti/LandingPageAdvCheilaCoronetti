(function () {
    'use strict';

    function initHeader() {
        const header = document.getElementById('siteHeader');
        if (!header) return;
        const onScroll = () => header.classList.toggle('scrolled', window.scrollY > 12);
        window.addEventListener('scroll', onScroll, { passive: true });
        onScroll();
    }

    function initNav() {
        const toggle = document.getElementById('navToggle');
        const nav = document.getElementById('mainNav');
        if (!toggle || !nav) return;
        toggle.addEventListener('click', () => {
            const open = nav.classList.toggle('open');
            toggle.classList.toggle('open', open);
            toggle.setAttribute('aria-expanded', String(open));
            document.body.classList.toggle('no-scroll', open);
        });
        nav.querySelectorAll('a').forEach((a) =>
            a.addEventListener('click', () => {
                nav.classList.remove('open');
                toggle.classList.remove('open');
                toggle.setAttribute('aria-expanded', 'false');
                document.body.classList.remove('no-scroll');
            })
        );
    }

    document.addEventListener('DOMContentLoaded', () => {
        initHeader();
        initNav();
    });
})();