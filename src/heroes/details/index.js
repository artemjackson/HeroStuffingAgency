"use strict";

import angular from "angular";

import HeroDetailsCtrl from "./controller";

export default angular.module("heroes.detailed", [

])
    .config($stateProvider => {
        $stateProvider.state("heroes.detailed", {
            controller: HeroDetailsCtrl,
            controllerAs: "ctrl",
            resolve: {
                hero: ($stateParams, heroService) => heroService.getById($stateParams.id)
            },
            template: require("./template.html"),
            url: "/:id"
        });
    });