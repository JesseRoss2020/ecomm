export type Pagination<T> = {
  pageIndex: number;
  pageSixe: number;
  count: number;
  data: T[];
};
