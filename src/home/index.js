"use strict";

import angular from "angular";

import MainCtrl from "./controller";

export default angular.module("home", [
    'ngFileUpload'
])
    .config($stateProvider => {
        $stateProvider.state("home", {
            controller: MainCtrl,
            controllerAs: "ctrl",
            template: require("./template.html"),
            url: "/"
        });
    });