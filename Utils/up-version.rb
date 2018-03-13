require 'json'

path = "package.json"
file = File.read(path)
data_hash = JSON.parse(file)

versions = data_hash['version'].split(".")
build = Integer(versions[2])
build = build + 1

versions[2] = build.to_s

newVersion = versions.join(".")

data_hash['version'] = newVersion

File.open(path,"w") do |f|
    f.write(data_hash.to_json)
  end
