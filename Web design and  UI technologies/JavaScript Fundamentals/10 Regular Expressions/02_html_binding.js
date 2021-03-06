// Write a function that puts the value of an object into the content/attributes of HTML tags.
// Add the function to the String.prototype

(function () {
    'use strict';
    var divTag = '<div data-bind-content="name"></div>',
        divTagOptions = {name: 'Steven'},
        anchorTag = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></а>',
        anchorTagOptions = {name: 'Elena', link: 'http://telerikacademy.com'},
        divTag2 = '<div data-bind-class="className"></div>',
        divTag2Options = {className: 'Academy'};

    if (!String.prototype.bind) {
        String.prototype.bind = function (options) {
            var dataTypes,
                dataValues,
                result,
                i,
                len;

            dataTypes = this.match(/[A-z]+=/g);
            dataTypes.forEach(function (item, index) {
                dataTypes[index] = item.match(/[A-z]+/g)[0];
            });

            dataValues = this.match(/"[A-z]+"/g);
            dataValues.forEach(function (item, index) {
                dataValues[index] = item.match(/[A-z]+/g)[0];
            });

            result = this;
            for (i = 0, len = dataTypes.length; i < len; i += 1) {
                switch (dataTypes[i]) {
                    case 'content':
                        result = insertContent(result, options[dataValues[i]]);
                        break;
                    case 'href':
                        result = insertHref(result, options[dataValues[i]]);
                        break;
                    case 'class':
                        result = insertClass(result, options[dataValues[i]]);
                        break;
                }
            }

            return result;
        };
    }

    function insertContent(element, content) {
        return element.replace(/></, '>' + content + '<');
    }

    function insertHref(element, href) {
        var updatedHref = '" href="' + href + '">';
        return element.replace(/">|" >/, updatedHref);
    }

    function insertClass(element, className) {
        var updatedClassName = '" class="' + className + '">';
        return element.replace(/">|" >/, updatedClassName);
    }

    console.log(divTag.bind(divTagOptions));
    console.log(anchorTag.bind(anchorTagOptions));
    console.log(divTag2.bind(divTag2Options));
})();