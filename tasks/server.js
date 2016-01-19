"use strict";

import config from "./config.json";
import gulp from "gulp";
import server from "gulp-webserver";

export default function () {
    return gulp.src(config.publicPath)
        .pipe(server(config.server));
}