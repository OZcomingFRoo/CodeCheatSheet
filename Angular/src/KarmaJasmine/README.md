# Angular's Testing tools - Jasmine + Karma JS

This section is puprely to test Angular testing tool Jasmine JS + Karma.

## Setup

Angular's Karma JS setup works by lauching Google Chrome's browser.
Since, I rarely use Google Chrome anymore, I had to download a NPM plugin to lauch on a different browser.
To change the testing browser, simply follow these steps:

1. Go to this link http://karma-runner.github.io/6.3/config/browsers.html. This should contain All the available browsers Karma supports.
2. Click on 1 of the links. E.g. I searched for Edge (new Chromium version) and got to this [page](https://www.npmjs.com/package/@chiragrupani/karma-chromium-edge-launcher)
3. Install it as a dev-dependency , of course, because we don't need it for production.
4. Be sure to follow the NPM instructions. You usually need to go to the Karma's config file and add the new NPM added + change the brwoser it should lauch. Check the projects Karma JS config file to see what I changed and added

## Notes

### Adding Custom matchers (16-04-2012)

Adding custom matchers seems easy at first, if you're using JavaScript and with this link [page](https://www.tutorialspoint.com/jasminejs/jasminejs_matchers.htm), all seems easy pizzy.
However, in Typescript, this is not as straight foward as it should.
I tried this link guide, but really I gave up after 30 minutes, as even the guide creator said, most of the built-in validators cover what you need
Here's the page if you wanna try to implament a custom matcher in Jasmine JS:
https://medium.com/bb-tutorials-and-thoughts/angular-how-to-add-jasmine-custom-matchers-in-unit-testing-3edd40f567ec

