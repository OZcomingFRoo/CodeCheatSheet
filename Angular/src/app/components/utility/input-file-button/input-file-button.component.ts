import { Component, ElementRef, EventEmitter, Input, OnInit, Output, ViewChild } from '@angular/core';

@Component({
  selector: 'app-input-file-button',
  templateUrl: './input-file-button.component.html',
  styleUrls: ['./input-file-button.component.css']
})
export class InputFileButtonComponent implements OnInit {

  @Input() fileTypes: Array<string> = [];
  @Output() onInputError = new EventEmitter<Error>();
  @Output() onSingleFile = new EventEmitter<File>();
  @Output() onMultipleFile = new EventEmitter<Array<File>>();
  @Input() buttonText: string = "Upload";
  @Input() cssClassArr: Array<string> = [];
  @ViewChild('file') input!: ElementRef<HTMLButtonElement>;
  constructor() { }

  ngOnInit(): void { }

  public get acceptFileType(): string {
    let acceptAttrStringVal = "";
    if (this.fileTypes) {
      this.fileTypes.forEach(type => acceptAttrStringVal += (type + " "));
    }
    return acceptAttrStringVal;
  }

  public get cssClasses(): string {
    let classes = "";
    if (this.fileTypes) {
      this.cssClassArr.forEach(cssClass => classes += (cssClass + " "));
    }
    return classes;
  }

  public inputFileChange(event: any) {
    let files: Array<File> = event.target.files;
    this.onSingleFile.emit(files[0]);
    this.onMultipleFile.emit(files);
  }

  Press() {
    this.input.nativeElement.click();
  }
}
