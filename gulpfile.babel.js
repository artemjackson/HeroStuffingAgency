import gulp from "gulp";
import gulpsync from "gulp-sync";
const gsync = gulpsync(gulp);

import clear from "./tasks/clear";
import resources from "./tasks/resources";
import scripts from "./tasks/scripts";
import styles from "./tasks/styles";
import vendor from "./tasks/vendor";
import server from "./tasks/server";
import watch from "./tasks/watch";

gulp.task("clear", clear);
gulp.task("resources", resources);
gulp.task("scripts", scripts);
gulp.task("styles", styles);
gulp.task("vendor", vendor);
gulp.task("server", server);
gulp.task("watch", watch);

gulp.task("build", ["styles", "scripts", "vendor", "resources"]);
gulp.task("rebuild", gsync.sync(["clear", "build"]));
gulp.task("default", gsync.sync(["rebuild", "server", "watch"]));