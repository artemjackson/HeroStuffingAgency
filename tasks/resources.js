"use strict";

import config from "./config.json";
import gulp from "gulp";

export default function () {
    gulp.src(config.images.src)
        .pipe(gulp.dest(config.publicPath + config.images.dest));

    gulp.src(config.fonts.src)
        .pipe(gulp.dest(config.publicPath + config.fonts.dest));

    return gulp;

};