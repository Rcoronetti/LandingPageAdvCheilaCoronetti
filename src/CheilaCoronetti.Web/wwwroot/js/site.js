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

    function initCarousel() {
        const root = document.querySelector('[data-carousel]');
        if (!root) return;
        const track = root.querySelector('.carousel-track');
        const slides = root.querySelectorAll('.carousel-slide');
        const dotsWrap = root.querySelector('.carousel-dots');
        if (!track || slides.length === 0) return;

        const total = slides.length;
        const autoplayMs = parseInt(root.dataset.autoplay || '6000', 10);
        let index = 0;
        let timer = null;

        const dots = [];
        for (let i = 0; i < total; i++) {
            const dot = document.createElement('button');
            dot.className = 'carousel-dot';
            dot.type = 'button';
            dot.setAttribute('aria-label', 'Ver avaliação ' + (i + 1) + ' de ' + total);
            dot.addEventListener('click', () => goTo(i, true));
            dotsWrap.appendChild(dot);
            dots.push(dot);
        }

        function goTo(i, manual) {
            index = (i + total) % total;
            track.style.transform = 'translateX(-' + index * 100 + '%)';
            dots.forEach((d, j) => d.classList.toggle('active', j === index));
            if (manual) restart();
        }

        function next() { goTo(index + 1, true); }
        function prev() { goTo(index - 1, true); }

        function start() { if (autoplayMs > 0 && !timer) timer = setInterval(next, autoplayMs); }
        function stop() { if (timer) { clearInterval(timer); timer = null; } }
        function restart() { stop(); start(); }

        const prevBtn = root.querySelector('[data-carousel-prev]');
        const nextBtn = root.querySelector('[data-carousel-next]');
        if (prevBtn) prevBtn.addEventListener('click', prev);
        if (nextBtn) nextBtn.addEventListener('click', next);

        root.addEventListener('mouseenter', stop);
        root.addEventListener('mouseleave', start);
        root.addEventListener('touchstart', stop, { passive: true });
        root.addEventListener('touchend', start, { passive: true });

        root.setAttribute('tabindex', '0');
        root.addEventListener('keydown', (e) => {
            if (e.key === 'ArrowLeft') prev();
            if (e.key === 'ArrowRight') next();
        });

        goTo(0, false);
        start();
    }

    function initReveal() {
        const els = document.querySelectorAll('[data-reveal]');
        if (els.length === 0) return;
        if (!('IntersectionObserver' in window)) {
            els.forEach((el) => el.classList.add('revealed'));
            return;
        }
        const io = new IntersectionObserver(
            (entries) => {
                entries.forEach((entry) => {
                    if (entry.isIntersecting) {
                        entry.target.classList.add('revealed');
                        io.unobserve(entry.target);
                    }
                });
            },
            { threshold: 0.15 }
        );
        els.forEach((el) => io.observe(el));
    }

    document.addEventListener('DOMContentLoaded', () => {
        initHeader();
        initNav();
        initCarousel();
        initReveal();
    });
})();