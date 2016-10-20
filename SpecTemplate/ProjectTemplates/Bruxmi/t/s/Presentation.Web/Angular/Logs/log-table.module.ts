import { NgModule }  from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from "../app-routing.module"
import { SharedModule } from '../Shared/shared.module';
import { LogTableComponent } from './log-table.component';


@NgModule({
    imports: [
        FormsModule, CommonModule, SharedModule, AppRoutingModule
    ],
    exports: [
        LogTableComponent
    ],
    declarations: [LogTableComponent],
})
export class LogModule { }
export const logQueryUrl: string = "api/logQuery/";