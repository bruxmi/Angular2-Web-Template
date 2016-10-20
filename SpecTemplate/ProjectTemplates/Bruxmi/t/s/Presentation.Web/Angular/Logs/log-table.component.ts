import {Component, OnInit} from '@angular/core';
import { ILog, ILogPaging } from './log';
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
    logPaging: ILogPaging;
    logs: ILog[];
    isLoading: boolean = false;

    constructor(private http: HttpDataService<ILogPaging>, private infoService: InfoBarEventService) {
    }

    ngOnInit() {
        this.logPaging = {
            Count: 0,
            IsDescending: true,
            PageIndex: 0,
            PageSize: 5,
            Logs: null,
            SearchTerm: "All"
        }
        this.getLogs();
    }

    public getLogs(): void {
        this.isLoading = true;
        this.http.update("api/logQuery/", 0, this.logPaging).subscribe(
            logs => this.onSucceedLoading(logs),
            error => this.onError(error)
        );

        this.infoService.showInfo("loading product...", "success")
    }

    public getPageCount(): string {
        let result = "0";
        if (this.logPaging.PageSize != 0) {
            result = (this.logPaging.Count / this.logPaging.PageSize).toPrecision();
        }
        return result;
    }

    public prevPage(): void {
        this.logPaging.PageIndex--;
        this.getLogs();
    }

    public nextPage(): void {
        this.logPaging.PageIndex++;
        this.getLogs();
    }

    public canClickPrevPage(): boolean {
        if (this.isLoading || this.logPaging.PageIndex == 0) {
            return false;
        }
        return true;
    }

    public canClickNextPage(): boolean {
        if (this.isLoading || this.logPaging.PageIndex == this.logPaging.Count) {
            return false;
        }
        return true;
    }

    private onSucceedLoading(logPaging: ILogPaging): void {
        this.logPaging = logPaging;
        this.logs = logPaging.Logs;
        this.isLoading = false;
        this.infoService.showInfo("Loaded logging entries", "success")
    }

    private onError(error: string): void {
        this.isLoading = false;
        this.infoService.showInfo("Loading product failed: " + error, "danger")
    }
}