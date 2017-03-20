// 
//    All Rights Reserved
//    This software is proprietary information of
//    Intelligent Sense
//    Use is subject to license terms.
//    Filename: app.js
// 

var app = angular.module('myApp', []);

app.controller('namesCtrl', function($scope) {
    $scope.users = [
        {"id": 0, "Name": "Roger Mcdonalid", "Tweets": 1, "Followers": 3, "ReTweets": 56, "Profile":"https://randomuser.me/api/portraits/men/36.jpg"},
        { "id": 1, "Name": "Florence Allen", "Tweets": 7, "Followers": 12, "ReTweets": 3, "Profile":"https://randomuser.me/api/portraits/women/29.jpg"},
        { "id": 2,"Name": "Erika Vargas", "Tweets": 9, "Followers": 67, "ReTweets": 4, "Profile":"https://randomuser.me/api/portraits/women/12.jpg"},
        { "id": 3,"Name": "Lily Marshall", "Tweets": 3, "Followers": 4, "ReTweets": 23, "Profile":"https://randomuser.me/api/portraits/women/11.jpg"},
        { "id": 4,"Name": "Aiden Terry", "Tweets": 9, "Followers": 3, "ReTweets": 1, "Profile":"https://randomuser.me/api/portraits/men/23.jpg"},
        {"id": 5, "Name": "Alexis Austin", "Tweets": 12, "Followers": 345, "ReTweets": 221, "Profile":"https://randomuser.me/api/portraits/women/31.jpg"},
        {"id": 6, "Name": "Mattie James", "Tweets": 15, "Followers": 546, "ReTweets": 34, "Profile":"https://randomuser.me/api/portraits/women/26.jpg"},
        {"id": 7, "Name": "Nicole Craig", "Tweets": 2, "Followers": 222, "ReTweets": 44, "Profile":"https://randomuser.me/api/portraits/women/24.jpg"},
        {"id": 8, "Name": "Wilma Wade", "Tweets": 3, "Followers": 45, "ReTweets": 234, "Profile":"https://randomuser.me/api/portraits/women/72.jpg"},
        {"id": 9, "Name": "Elijah Murphy", "Tweets": 6, "Followers": 613, "ReTweets": 14, "Profile":"https://randomuser.me/api/portraits/men/13.jpg"},
        {"id": 10, "Name": "Ida Ford", "Tweets": 13, "Followers": 23, "ReTweets": 21, "Profile":"https://randomuser.me/api/portraits/women/6.jpg"}
        ];
});


//Extracted from https://toddmotto.com/everything-about-custom-filters-in-angular-js/
app.filter('startsWithLetter', function () {
    return function (items, letter) {
        var filtered = [];
        var letterMatch = new RegExp(letter, 'i');
        for (var i = 0; i < items.length; i++) {
            var item = items[i];
            if (letterMatch.test(item.Name.substring(0, 1))) {
                filtered.push(item);
            }
        }
        return filtered;
    };
});