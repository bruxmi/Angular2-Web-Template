import {Component, OnInit} from '@angular/core';
import { ILog } from './log';
import { logQueryUrl } from "./log-table.module";
import { HttpDataService } from "../Shared/Http/http-data.service";
import { InfoBarEventService } from "../Shared/Info/info-bar-event.service";

@Component({
    moduleId: module.id,
    selector: 'log-table',
    templateUrl: 'log-table.component.html',
    styleUrls: ['log-table.component.css']
})

export class LogTableComponent implements OnInit {

    pageTitle: string = "Logs"
    logs: ILog[];
    constructor(private http: HttpDataService<ILog>, private infoService: InfoBarEventService) {
    }

    ngOnInit() {
        this.getLogs();
    }

    getLogs(): void {
        this.http.getAll("api/logQuery/").subscribe(
            logs => this.onSucceedLoading(logs),
            error => this.onError(error)
        );
        this.infoService.showInfo("loading product...", "success")
    }

    onSucceedLoading(logs: ILog[]): void {
        this.logs = logs;
        this.infoService.showInfo("Loaded logging entries", "success")
    }

    onError(error: string): void {
        this.infoService.showInfo("Loading product failed: " + error, "danger")
    }

}