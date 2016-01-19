"use strict";

import angular from "angular";

import heroes from "./heroes";
import join from "./join";
import home from "./home";

import HeroService from "./service";

export default angular.module("app", [
    "ui.router",
    "ngMaterial",

    home.name,
    heroes.name,
    join.name
])
    .service("heroService", HeroService)
    .config($locationProvider => {
        $locationProvider.html5Mode(true);
    });