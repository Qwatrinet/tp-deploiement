FROM node:lts

WORKDIR /app

COPY . . 

RUN npm install

EXPOSE 3000

ENTRYPOINT [ "node", "app.js" ]