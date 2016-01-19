"use strict";

import angular from "angular";

import JoinCtrl from "./controller";

export default angular.module("join", [
    'ngFileUpload'
])
    .config($stateProvider => {
        $stateProvider.state("join", {
            controller: JoinCtrl,
            controllerAs: "ctrl",
            template: require("./template.html"),
            url: "/join"
        });
    });