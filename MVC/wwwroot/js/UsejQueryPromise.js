'strict mode';
let promiseOptions;
(function (promiseOptions) {
    promiseOptions[promiseOptions["resolve"] = 0] = "resolve";
    promiseOptions[promiseOptions["reject"] = 1] = "reject";
    promiseOptions[promiseOptions["notify"] = 2] = "notify";
})(promiseOptions || (promiseOptions = {}));

$(function () {
    console.log("Start using buttons");
    $("#btnPromiseResolve").click(function ($event) {
        PromiseAsyncWrapper(promiseOptions.resolve);
    });
    $("#btnPromiseReject").click(function ($event) {
        PromiseAsyncWrapper(promiseOptions.reject);
    });
    $("#btnPromiseNotify").click(function ($event) {
        PromiseAsyncWrapper(promiseOptions.notify);
    });

    /** @param {number} option */
    function PromiseAsyncWrapper(option) {
        let prm = ThejQueryPromiseAsync(option);
        prm.done(function (data) { console.log("Done Event got this ::: ", data); })
            .fail(function (data) { console.log("Fail Event got this ::: ", data); })
            .progress(function (data) { console.log("Progress Event got this ::: ", data); });
        prm.promise();
    }
    /** @param {number} option 
     *  @returns {JQueryDeferred<string>}
     */
    function ThejQueryPromiseAsync(option) {
        let jQuertyPromise = $.Deferred();
        switch (option) {
            case promiseOptions.resolve: {
                jQuertyPromise.resolve("From Resolve Fire");
                break;
            }
            case promiseOptions.reject: {
                jQuertyPromise.reject(new Error("From Reject Fire"));
                break;
            }
            case promiseOptions.notify: {
                jQuertyPromise.notify("From Notify Fire");
                break;
            }
        }
        return jQuertyPromise;
    }
});