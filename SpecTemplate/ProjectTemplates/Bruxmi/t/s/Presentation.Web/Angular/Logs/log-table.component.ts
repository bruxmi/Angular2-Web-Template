import {Component, OnInit} from '@angular/core';
import { FormGroup } from '@angular/forms';
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
    pageSizes: any;
    logLevelFilter: any;

    constructor(private http: HttpDataService<ILogPaging>, private infoService: InfoBarEventService) {
    }

    ngOnInit() {
        this.pageSizes = [{ key: "1", value: 50 },
            { key: "2", value: 100 },
            { key: "3", value: 200 }
        ];
        this.logLevelFilter = [
            { key: "0", value: "All" },
            { key: "1", value: "Debug" },
            { key: "2", value: "Information" },
            { key: "3", value: "Warning" },
            { key: "4", value: "Error" },
            { key: "5", value: "Fatal" }
        ];

        this.logPaging = {
            Count: 0,
            IsDescending: true,
            PageIndex: 0,
            PageSize: 50,
            Logs: null,
            SearchTerm: "All"
        }
        this.getLogs();
    }

    public pageSizeChanged(pageSizeIndex: string) {
        let convertedPageSizeIndex = Number.parseInt(pageSizeIndex) - 1;
        this.logPaging.PageSize = this.pageSizes[convertedPageSizeIndex].value;
        this.getLogs();
    }

    public logLevelFilterChanged(logLevelIndex: string) {
        let convertedLogLevelIndex = Number.parseInt(logLevelIndex) - 1;
        this.logPaging.SearchTerm = this.logLevelFilter[convertedLogLevelIndex].value;
        this.getLogs();
    }
   

    public getPageCount(): string {
        let result = "1";
        if (this.logPaging.PageSize != 0) {
            result = (this.logPaging.Count / this.logPaging.PageSize).toString();
            result = Number.parseInt(result).toString();
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
        if (!this.isLoading && this.logPaging.PageIndex > 0) {
            return true;
        }
        return false;
    }

    public canClickNextPage(): boolean {
        if (!this.isLoading && this.logPaging.PageIndex <= this.logPaging.Count) {
            return true;
        }
        return false;
    }

    private getLogs(): void {
        this.isLoading = true;
        this.http.update("api/logQuery/", 0, this.logPaging).subscribe(
            logs => this.onSucceedLoading(logs),
            error => this.onError(error)
        );

        this.infoService.showInfo("loading product...", "success")
    }

    private onSucceedLoading(logPaging: ILogPaging): void {
        this.logPaging = logPaging;
        this.logPaging.PageSize = Number.parseInt(this.logPaging.PageSize.toString());
        this.logs = logPaging.Logs;
        this.isLoading = false;
        this.infoService.showInfo("Loaded logging entries", "success")
    }

    private onError(error: string): void {
        this.isLoading = false;
        this.infoService.showInfo("Loading product failed: " + error, "danger")
    }
}