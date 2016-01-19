"use strict";

import angular from "angular";

import details from "./details";
import HeroesCtrl from "./controller";
import CurrencyService from "./currencyService";

export default angular.module("heroes", [
    details.name
])
    .service("currencyService", CurrencyService)
    .config($stateProvider => {
        $stateProvider.state("heroes", {
            controller: HeroesCtrl,
            controllerAs: "ctrl",
            resolve: {
                heroes: heroService => heroService.getAll(),
                currency: currencyService => currencyService.getExchangeRateFor()
            },
            template: require("./template.html"),
            url: "/heroes"
        });
    });